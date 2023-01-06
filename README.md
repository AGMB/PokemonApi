# Information
Autor: Alex Adriano; Jimmy Peñafiel

Version de Plantilla: 1.1.0

	Pokemon			
            |
            Pokemon.API
            |
            Pokemon.Domain
            |
            Pokemon.Entity
            |
            Pokemon.Infraestructure
            |
            Pokemon.Repository
            |
            Pokemon.Test


# Documentation
Luego de la configuracion del proyecto base puede ser compilado y leventando en ambiente local para su validacion.

# Build
configmap.desa.json, configmap.test.json, configmap.prod.json: Se encuentran los tags de configuración para consultar ejemplo: llaves, cadenas de conexión que han sido previamentes configuradas en centralizada. 

oc-dev-config.yml, oc-test-config.yml, oc-prod-config.yml: Configuración de archivo para asignacion de recursos para cada contenedor.

# Framework
| Plantilla | Versión | Fecha de Actualización |
| ------ | ------ | ------ |
| arq-microservicio-netcore-60 | 1.0.0 | 26/07/2022 |
| arq-microservicio-netcore-60 | 1.1.0 | 01/11/2022 |


# Framework Description
Documentar cada actualización realizada en la plantilla
***
      Versión de Plantilla: 1.1.0
      Fecha de Actualización: 01/11/2022 

      Detalles de Actualización:
      - Se agrega registro de logs
      - Se configura el Nuget MethodBoundaryAspect.Fody
***