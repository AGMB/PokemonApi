# Information
Entidades: entradas y salida del servicio, DTO de servicios

	Pokemon.Entity					
						|
						Entrada
						Salida
						Services						
							|
							ServicesName (Nombre del Servicio a llamar)
									|
									Entrada
									Salida


# Documentation
ServicesName: nombre del servicio Externo. Ejemplo: Pagueya, Sipecom, RegistroCivil, LinkSolutions, etc


# Build 
Entrada.cs: Se definen las entradas del servicio a construir

Salidas.cs: Se definen las salidas del servicio a construir
Nota. Si existe más de un método debería ser agrupado por el nombre del método


# Nuget Packages
1. BP.API.Entidades(1.0.2)

