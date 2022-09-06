#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat
#Stage 1: base
# create an intermediate image base that exposes ports 80 and 443, and sets the working directory to /app.
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#Stage 2: build
#You can see that the build stage starts from a different original image from the registry (sdk rather than aspnet), rather than continuing from base.
#The sdk image has all the build tools, and for that reason it's a lot bigger than the aspnet image, which only contains runtime components.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MartiFood/MartiFood.csproj", "MartiFood/"]
RUN dotnet restore "MartiFood/MartiFood.csproj"
COPY . .
WORKDIR "/src/MartiFood"
RUN dotnet build "MartiFood.csproj" -c Release -o /app/build


#Final Stage
#The final stage starts again from base, and includes the COPY --from=publish to copy the published output to the final image. 
#This process makes it possible for the final image to be a lot smaller, since it doesn't need to include all of the build tools that were in the sdk image.
FROM build AS publish
RUN dotnet publish "MartiFood.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MartiFood.dll"]