nuget.exe pack ..\1-Infrastructure\Skymate.Infrastructure\Skymate.Infrastructure.csproj -Build -Properties Configuration=Release

nuget.exe pack ..\1-Infrastructure\Skymate.Communication\Skymate.Communication.csproj -Build -Properties Configuration=Release
nuget.exe pack ..\1-Infrastructure\Skymate.Data.EntityFramework\Skymate.Data.EntityFramework.csproj -Build -Properties Configuration=Release

nuget.exe pack ..\3-Application\Skymate.Web.Framework\Skymate.Web.Framework.csproj -Build -Properties Configuration=Release




nuget.exe push *.nupkg -s http://139.196.13.165/SkymateNugetServer qazwsx123
pause
