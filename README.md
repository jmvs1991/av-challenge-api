# America Virtual Challenge (Api)

Api desarrollado en C# con .Net Core 5.0. Usando una capa de conexión que es una dll llamada "Connection" que usa Entity Framework (EF) para realizar la conexión con la base de datos.

## Base de datos

Para la base de datos se utilizo SqlServer en un contenedor de docker, aunque no es limitante. Se utilizo el concepto de codefirst donde la tablas se generan desde las clases del proyecto, y la base de datos se actualiza utilizando migraciones.

    - En docker (Recomendado)

        1. Ubicarse dentro de la carpeta de la DLL connection usando una consola de comandos.
        
        2. Si se esta usando un sistema operativo windows hay que crear un volumen externo usando el comando 'docker-compose volume create av_bd_data'.

        3. Levantar el servicio de docker que contiene el manejador de base de datos usando el comando 'docker-compose up AV_BD.

Si ya se tiene un ambiente que tiene una base de datos SqlServer se puedo obviar el paso de docker.

#### Datos de conexión

    - Servidor: localhost
    - Puerto: 14333(Puerto externo de docker)
    - Base de datos: CHALLENGE
    - Usuario: sa
    - Password: avChallenge2021

Nota: Cualquier cambio en los datos de conexión hay que actualizar los datos de la cadena de conexión en el archivo appsettings.json.

### Creación de la base de datos y actualización de datos.

    - Migraciones (Recomendado)