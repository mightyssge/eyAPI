# ey app backend

Backend para la gestión de proveedores.

## Tabla de contenidos

- [Instalación](#instalación)
- [Uso](#uso)


## Instalación

1. Clonar el repositorio.
2. Abrir la solución en Visual Studio.
3. Restaurar los paquetes de NuGet.
4. Compilar la solución.

## Uso

1. Configurar la cadena de conexión a la base de datos en el archivo `appsettings.json`, de igual manera la base de datos esta hosteada en azure el string de la conexion se encuentra en `appsettings.json` asi que si se desease ver en SSMS puede hacerlo con esas credenciales por lo cual la data también esta cargada.
2. Ejecutar la aplicación utilizando IIS Express.
3. Acceder a los endpoints de la API utilizando una herramienta como Postman o Swagger UI.

OJO: el trabajo corre en el puerto 20045
