# Utiliser l'image officielle Jenkins LTS comme base
FROM jenkins/jenkins:lts

# Installer .NET SDK (ici, la version 9.0, vous pouvez ajuster selon votre besoin)
USER root
RUN apt-get update && apt-get install -y \
    wget \
    apt-transport-https \
    software-properties-common

RUN wget https://packages.microsoft.com/config/ubuntu/20.04/prod.list \
    -O /etc/apt/sources.list.d/dotnetdev.list

RUN wget https://packages.microsoft.com/keys/microsoft.asc \
    -O /etc/apt/trusted.gpg.d/microsoft.asc

RUN apt-get update && apt-get install -y \
    dotnet-sdk-9.0

# Revenir à l'utilisateur Jenkins pour une sécurité accrue
USER jenkins

# Définir le port pour Jenkins
EXPOSE 8080
EXPOSE 50000

# Démarrer Jenkins
CMD ["jenkins-server"]
