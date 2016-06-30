---------------------------------------------------------------------------------------------------
damageTypePhy = 1
damageTypeMag = 2
---------------------------------------------------------------------------------------------------
EffectDamage = 
{
	--basic data
	amount,
	amountFunction,
	attackFactor,
	damageType,
	isHeal,
	fixedCriticalRatio,
	
	--flag
	kill,
	live,
	noMiss,
	absoluteCritical,
	noCritical,
	
	--state data
	isCritical,
}
setmetatable(EffectDamage, {__index = Effect})
---------------------------------------------------------------------------------------------------
function EffectDamage:Apply(curTime)
	if self:ApplyBasic(curTime) == false then
		return 
	end
	
	self:CalculateHit()
	if self.hit = HIT_SUCCESS then
		self:CalculateEnergy()
		if self.kill then
			--kill
		else
			self:CalculateCritical()
			self:CalculateDamage(self.applyTime)
		end
	end
end
---------------------------------------------------------------------------------------------------
function EffectDamage:CalculateHit()
	self.hit = HIT_SUCCESS
	if not(self.isHeal) then
		local invulnerable = self.target.flags.invulnerable
		if invulnerable and invulnerable > 0 then
			self.hit = HIT_IMMUNE
			return
		end
	end
	
	if not(self.noMiss) then
		self.hit = CalculateBasicHit(self.caster, self.target)
	end
end
---------------------------------------------------------------------------------------------------
function EffectDamage:CalculateCritical()
	self.isCritical = true
	if self.absoluteCritical then
		self.isCritical = true
		return
	end
	if self.noCritical then
		self.isCritical = nil
		return
	end
	
	local criticalRandNum = math.random()
	if criticalRandNum > caster.criticalRate then
		self.isCritical = nil
	end
end
---------------------------------------------------------------------------------------------------
function EffectDamage:CalculateDamage(curTime)
	local lifeAmount
	if self.amountFunction then
		lifeAmount = self.amountFunction(self)
	elseif self.attackFactor
		local attack = self.caster.phyAttack
		if self.damageType == damageTypeMag then
			attack = self.caster.magAttack
		end
		lifeAmount = self.attackFactor * attack
		if self.amount then
			lifeAmount = self.amount + lifeAmount
		end
	end
	
	--暴击系数
	if self.isCritical then
		lifeAmount  = lifeAmount * CRITICAL_DMG_RATIO
	end
	
	local damageConvertRatio = 1
	if not(self.isHeal) then
		damageConvertRatio = -1
		--受伤比
		--1/(1+(B防御力)/I(lv2))
		local injuryRatio = 1.0/(1.0 + (self.target.defend)/GetInjuryAdjustNum(math.min(self.caster.level, self.target.level)))
		if injuryRatio > 0.25 then
			injuryRatio = 0.25
		end
		injuryRatio = injuryRatio + self.target.injuryRatio
		lifeAmount = lifeAmount * injuryRatio
		
		--属性相克系数
		if self.damageType == damageTypeMag then
			lifeAmount = lifeAmount * GetPropertyInfluenceRatio(self.caster.property, self.target.property)
		end
		
		--副本系数？什么玩意
		--lifeAmount = lifeAmount * SpellService.level.injuryRatio
	end
	lifeAmount = math.ceil(lifeAmount)
	lifeAmount = lifeAmount * damageConvertRatio
	
	--damage response
	--suppose only target has damage response for simply
	local activeBuffList = self.target.buffList
	if activeBuffList then
		for _, buff in pairs(activeBuffList) do
			buff:DamageResponse(lifeAmount, self)
		end
	end
	
	--change unit attribute
	if self.isHeal then
	self.target.life = self.target.life + lifeAmount
	if self.target.life < 0 then
		self.target.life = 0
		SpellService:OnUnitDead(self.target)
	elseif self.target.life > self.target.maxLife then
		self.target.life = self.target.maxLife
	end
end
---------------------------------------------------------------------------------------------------