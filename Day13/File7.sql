Create proc prcPolicyInfo
                           @policyId INT
AS
BEGIN
            Declare
			        @appNumber varchar(30),
					@annualPremium numeric (9,2),
					@paymode varchar(30)
			Begin
			     if exists(select *from Policy where PolicyId = @policyId)
				 Begin
				 select @appNumber = AppNumber, @annualPremium = AnnualPremium,
				 @paymode = dbo.fnPaymode(paymentModeId)
				 from Policy where PolicyId = @policyId
				 Print 'Application Number ' +@appNumber
				 Print 'Annual Premium ' +convert(varchar,@annualPremium)
				 Print 'Payment Mode ' +@paymode
				 END
				 ELSE
				 BEGIN
				      Print 'Policy Record is Not Found..'
				  End
			End
END
Go

Exec prcPolicyInfo 2
Go
