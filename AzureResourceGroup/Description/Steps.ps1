#
# Steps.ps1
#

Get-ExecutionPolicy

Set-ExecutionPolicy -ExecutionPolicy <PolicyName> (Unrestricted)

Add-AzureAccount -Environment <EnvironmentName>

Select-AzureSubscription <SubscriptionName>