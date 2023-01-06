# Information
Implementación de la infraestructura para llamar al repositorio.

	Pokemon.Infraestructure						
						|
						Services						
							|
							ServicesName (Nombre del Servicio a llamar)
									|
									ServicesNameInfraesctructura

# Documentation
ServicesName : nombre del servicio Externo. Ejemplo: Pagueya, Sipecom, RegistroCivil, LinkSolutions, etc

Validaciones: Se definen en esta estructura las clases para validar las Header, body y validaciones adicionales.

# Build 
ServiceNameInfraestructura.cs: infraestructura del servicio a llamar al repositorio


# Nuget Packages
1.  FluentValidation(11.2.0)
2.  MethodBoundaryAspect.Fody(2.0.145)