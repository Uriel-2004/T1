from email.mime import base


def T1PY():

    print("==MENÚ DE CARRERAS==")
    print("1. Medicina-Medicina\n 2. Medicina-Enfermería\n 3. Medicina-Psicología\n 4. Medicina-Nutrición\n 5. Ingernieria-Sistemas\n 6. Ingenieria-Industrial\n 7. Ingernieria-Mecatrónica\n 8. Negocios-Administración\n 9. Negocios-Contabilidad\n 10. Negocios-Marketing\n 11.Educación-Inicial\n 12. Educación-Primaria\n 13. Educación-Secunadria")

    opcion = int(input("Número de la carrera"))

    match opcion:

        case 1: opcion = base, "MEDICINA", 22500
        case 2: opcion = base, "ENFERMERIA", 15300
        case 3: opcion = base, "PSICOLOGÍA", 12000
        case 4: opcion = base, "NUTRICIÓN", 10000
        case 5: opcion = base, "SISTEMAS", 17000
        case 6: opcion = base, "INDUSTRIAL", 15300
        case 7: opcion = base, "MECATRÓNICA", 20300
        case 8: opcion = base, "ADMINISTRACIÓN", 15300
        case 9: opcion = base, "CONTABILIDAD", 14000
        case 10: opcion = base, "MARKETING", 16700
        case 11: opcion = base, "INICIAL", 10000
        case 12: opcion = base, "PRIMARIA", 12000
        case 13: opcion = base, "SECUNDARIA", 12000
        case _: 
            print("Opción inexistente")

            cred = int(input("Ingrese la cantidad de créditos"))
            promgen = float(input("Ingrese el promedio general de los cursos del estudiante"))
            
            Escuela = int(input("Escuela nacional [1] o no nacional [2]?"))
            pagaciclo = int(input("Paga completo el ciclo? Sí [3] No [4]"))

            if 1 <= cred <= 12:
                final = base * 0.75

            elif 13 <= cred <= 22:

                final = base

            elif 23 <= cred <= 26:

                final = base * 1.15

            else:

               print("El monto de créditos no es válido")



            if promgen >= 16:

                final * 0.90

            if Escuela == 1:

                final = final * 0.85


            if promgen >= 16:
                
                final = final * 0.90

            if pagaciclo == 1:

                final = final * 0.95




























     





        




