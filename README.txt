# Sistema de Gestión de Empleados

Aplicación de consola desarrollada en **C#** que permite realizar una gestión básica de empleados, simulando reglas de negocio y buenas prácticas de desarrollo de software, incluyendo el uso de Git y GitHub.

---

## Funcionalidades Implementadas

- Registro de empleados
- Consulta de información de un empleado

Cada funcionalidad fue desarrollada en una rama independiente y posteriormente fusionada a la rama principal.

---

## Tipos de Pruebas Identificados

### Pruebas Funcionales
Estas pruebas verifican que las funcionalidades principales del sistema funcionen correctamente, como el registro y la consulta de empleados.

### Pruebas de Validación de Datos
Permiten comprobar que el sistema valide correctamente:
- Campos obligatorios
- Valores numéricos válidos
- Valores no numéricos
- Rangos permitidos

### Pruebas de Lógica de Negocio
Se utilizan para validar reglas de negocio, tales como:
- Evitar el registro de empleados con IDs duplicados
- Verificar que la fecha de finalización del contrato sea futura


---

## Escenarios de Prueba

| Escenario | Datos de Entrada | Resultado Esperado |
|---------|-----------------|-------------------|
| Registro exitoso | Datos válidos | Confirmación de la operación |
| ID duplicado | ID existente | Mensaje de error |
| Correo inválido | Sin símbolo @ | Mensaje de error |
| Fecha de contrato inválida | Fecha pasada | Mensaje de error |
| ID no numérico | Texto en lugar de número | Mensaje de error |

---

## Caso de Prueba

**Nombre del caso:** Registro exitoso de empleado  

**Datos de entrada:**
- ID: 1  
- Nombre completo: Juan Pérez  
- Correo electrónico: juan@gmail.com  
- Fecha fin de contrato: 01/01/2026  

**Resultado esperado:**  
Empleado registrado correctamente.

**Resultado obtenido:**  
Empleado registrado correctamente.

**Estado:** Aprobado

---

## Tecnologías Utilizadas

- Lenguaje: C#
- Tipo de aplicación: Consola
- Control de versiones: Git
- Repositorio remoto: GitHub

---

## Observaciones

El proyecto aplica buenas prácticas de programación, separación de responsabilidades, validación de datos, uso de ramas por funcionalidad y documentación de pruebas, simulando un entorno básico de desarrollo de software en la industria.
