echo @off

"%ProgramFiles%\Microsoft\ILMerge\ILMerge.exe" /out:".\bin\Debug\MergedFramework.dll" ".\bin\Debug\Framework.dll" /log ".\bin\Debug\Framework.Math.dll" ".\bin\Debug\Framework.Ux.dll"

"%ProgramFiles%\Microsoft\ILMerge\ILMerge.exe" /out:".\bin\Debug\pt-PT\MergedFramework.Resources.dll" ".\bin\Debug\pt-PT\Framework.Resources.dll" /log ".\bin\Debug\pt-PT\Framework.Math.Resources.dll" ".\bin\Debug\pt-PT\Framework.Ux.Resources.dll"

echo @on