FROM mcr.microsoft.com/dotnet/core/aspnet:3.0

#设置工作目录
WORKDIR /app

#复制发布文件到/app下
COPY . /app

#设置端口
EXPOSE 81

#使用dotnet demo01.dll来运行asp.net core项目，注意大小写
ENTRYPOINT ["dotnet", "demo02.dll"]
