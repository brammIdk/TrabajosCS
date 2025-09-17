opc = int(input("seleccione una opcion (1-4): "))
match opc:
    case 1:
        print("selecciono el caso 1")
    case 2:
        print("selecciono el caso 2")
    case 3:
        print("selecciono el caso 3")
    case 4:
        print("saliendo...")        
    case _:
        print("opcion invalida")