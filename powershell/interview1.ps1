function DoWork
{

  $scriptBlock =  {
      #Do some background work
      $Time2Sleep = [int]$argsN
      Start-Sleep -s $Time2Sleep
      Write-Output "Slept $args"
  }

  DisplayMessage("Processing Starts")

  $array = @(3,2,1)
  foreach ($a in $array)
  {
      Start-Job -Name "DoActualWork" $ScriptBlock -ArgumentList $a
  }

  While (Get-Job -Name "DoActualWork" | where { $_.State -eq "Running" } )
  {
      Start-Sleep 5
  }
    
  foreach ($job in Receive-Job -Name "DoActualWork")
  {
      Write-Host $job
  }

  DisplayMessage("Processing Ends")
}

function global:DisplayMessage([string]$message)
{
    Write-Host $message
}

DoWork