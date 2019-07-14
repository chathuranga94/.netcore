# Install .NET CORE 2.2 # 

wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb 
sudo dpkg -i packages-microsoft-prod.deb 

sudo add-apt-repository universe 
sudo apt-get install apt-transport-https 
sudo apt-get update 
sudo apt-get install dotnet-sdk-2.2 

dotnet --version 
dotnet --info 

dotnet new console 
dotnet run 

dotnet new mvc 
dotnet new web 
dotnet new
