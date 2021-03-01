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

    - Generar base de datos y datos usando migraciones de EF(Recomendado)

        - Requerimientos previos:

            1. Manejador de base de datos corriendo.
            2. Tener instalado Net core cli(https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
            3. Tener el appsettings.json con los datos reales de conexión.
        
        1. Ubicarse dentro de la carpeta 'av-challenge-api\av-challenge-api' 

        2. Ejecutar el comando 'dotnet ef database update'

Nota: es importante que el usuario utilizado en la conexión tenga permisos para crear y editar base de datos.

    - Generar base de datos mediante archivo .bacpac

        En el correo se adjuntara un archivo .bacpac para generar la base de datos desde un respaldo.

    - Generar base de datos mediante script

        En el correo se adjuntara un .sql con los script para crear la base de datos.

### Ejecutar el proyecto

    Una vez ejecutado los pasos anteriores se puede ejecutar el proyecto api, el mismo mostrara un swagger.