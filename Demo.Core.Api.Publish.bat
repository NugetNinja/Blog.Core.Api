color B

echo "*************��ʼɾ�����ļ�***************"
del  PublishFiles\*.*   /s /q

echo "*************��ʼ��ԭ����***************"
dotnet restore

echo "*************��ʼ���빤��***************"
dotnet build

cd Demo.Core.Api.WebApi

echo "*************��ʼ��������***************"
dotnet publish -o ..\Demo.Core.Api.WebApi\bin\Debug\netcoreapp2.2\

md ..\PublishFiles

xcopy ..\Demo.Core.Api.WebApi\bin\Debug\netcoreapp2.2\*.* ..\PublishFiles\ /s /e 

echo "Successfully!!!! ^ please see the file PublishFiles"

cmd