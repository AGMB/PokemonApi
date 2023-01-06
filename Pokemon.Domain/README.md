# Information
Dominio: se determina las interfaces a implementar

	Pokemon.Dominio
						|
						Interfaces
							|
							Propiedades
							Services						
								|
								ServicesName (Nombre del Servicio a llamar)


# Documentation
ServicesName: nombre del servicio Externo. Ejemplo: Pagueya, Sipecom, RegistroCivil, LinkSolutions, etc


# Build 
IServiceNameInfraestructura.cs: interface, serviceName infraestructura del servicio a invocar.

IServiceNameRepositorio.cs: interface, servicesName del repositorio del servicio a invocar.


# Nuget Packages
1. BP.Comun.Centralizada(1.0.2)
2. BP.Comun.Extensiones(1.0.0)
3. BP.Comun.Logs(2.0.0)
4. BP.Comun.Propiedades(1.0.0)
5. BP.Functional.Core(1.0.0)
6. BP.API.Constantes(1.0.0)

