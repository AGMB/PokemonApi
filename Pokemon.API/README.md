# Information
Microservicio para invocar a servicios externos.

WSClientes0009 ====>  www.servicioxterno.com/prueba.aspx

# Documentation 
Controla la ejecución del programa dirigiendo las llamadas a otras funciones dentro del proyecto.

SwaggerDoc: en el archivo Program.cs , agregar nombre del servicio, título, descripción 

# Build 
ServicioBaseController.cs : representa el nombre del dominio en la que implementa el controlador Ejemplo: ClienteController.cs

InitConfig.cs : carga inicial de componentes, centralizada.

Program.cs : Clase de inicializacion del servicio, carga centralizada, injection de repositorio, infraestructura.


# Nuget Packages
1. BP.Provider(1.0.0)
2. Microsoft.VisualStudio.Azure.Containers.Tools.Targets(1.15.1)
3. Swashbuckle.AspNetCore(6.2.3)
4. Microsoft.AspNetCore.Mvc.Versioning(5.0.0)
5. MethodBoundaryAspect.Fody(2.0.145)