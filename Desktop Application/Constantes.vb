﻿Module Constantes
    '//////////////////
    '    APLICACIÓN
    '//////////////////
    Friend Const APPLICATION_DATABASE_GUID As String = "{E172BD34-551E-481d-BE3D-76876D0819D3}"

    '//////////////////
    '    VARIOS
    '//////////////////
    Friend Const PERSONA_GENERO_NOESPECIFICA As String = "-"
    Friend Const PERSONA_GENERO_MASCULINO As String = "M"
    Friend Const PERSONA_GENERO_FEMENINO As String = "F"

    Friend Const PESADA_TIPO_ENTRADA As String = "E"
    Friend Const PESADA_TIPO_SALIDA As String = "S"
    Friend Const PESADA_TIPO_NINGUNA As String = "N"

    Friend Const PESADA_TIPO_PERIODICIDAD_FRECUENTE As String = "F"
    Friend Const PESADA_TIPO_PERIODICIDAD_ESPORADICA As String = "E"
    Friend Const PESADA_TIPO_PERIODICIDAD_NUNCA As String = "N"

    '////////////////////////////////////
    '   SERVICIOS DE ACONDICIONAMIENTO
    '////////////////////////////////////
    Friend Const ALMACENAJE_TIPO_DIAS_GRACIA_FIJO As String = "D"
    Friend Const ALMACENAJE_TIPO_DIAS_GRACIA_SI_RETIRA_ANTES As String = "G"
    Friend Const ALMACENAJE_TIPO_FECHA_FIJA As String = "F"

    Friend Const PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_NINGUNO As String = "N"  'NO REDONDEA, CALCULA CON LA FRACCIÓN
    Friend Const PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_ENTERO As String = "E"   'REDONDEA HASTA 0.4 AL ENTERO MENOR, DESPUÉS AL ENTERO SIGUIENTE
    Friend Const PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_SUPERIOR As String = "S"    'REDONDEA AL ENTERO SUPERIOR
    Friend Const PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_INFERIOR As String = "I"    'REDONDEA AL ENTERO INFERIOR

    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_FIJA As String = "F"     'NO UTILIZA ESCALA, ESPECIFICA UN IMPORTE FIJO PARA TODOS LOS PUNTOS
    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_ESCALA As String = "E"   'UTILIZA LAS ESCALAS

    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_PORPUNTO As String = "P"          'BUSCA EN LA ESCALA Y APLICA LA TARIFA CORRESPONDIENTE A CADA RANGO DE PUNTOS
    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_COMPLETA As String = "C"          'BUSCA EN LA ESCALA Y APLICA LA MISMA TARIFA PARA TODOS LOS PUNTOS
    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADO As String = "S"       'BUSCA EN LA ESCALA Y COBRA DIRECTAMENTE EL IMPORTE ENCONTRADO SIN CONTAR LOS PUNTOS
    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADOYZARANDEO As String = "Z"      'BUSCA EN LA ESCALA Y COBRA DIRECTAMENTE EL IMPORTE ENCONTRADO EN CONCEPTO DE SECADO Y ZARANDEO
    Friend Const PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_TODOCONCEPTO As String = "T" 'BUSCA EN LA ESCALA Y COBRA DIRECTAMENTE EL IMPORTE ENCONTRADO POR TODO CONCEPTO (NO COBRA PARITARIA, ZARANDEO, FUMIGADO Y MEZCLA)

    '////////////////
    '    REPORTES
    '////////////////

    '///////////////////////////////////
    '    PARÁMETROS DE LOS REPORTES
    '///////////////////////////////////
    Friend Const REPORTE_PARAMETRO_PERSONA As String = "PERS"

    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER As String = "NUIN"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL As String = "NUDE"
    Friend Const REPORTE_PARAMETRO_TIPO_MONEY As String = "MONY"
    Friend Const REPORTE_PARAMETRO_TIPO_DATETIME As String = "DATI"
    Friend Const REPORTE_PARAMETRO_TIPO_DATE As String = "DATE"
    Friend Const REPORTE_PARAMETRO_TIPO_TIME As String = "TIME"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM As String = "YMFR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO As String = "YMTO"
    Friend Const REPORTE_PARAMETRO_TIPO_BOOLEAN As String = "BOOL"
End Module