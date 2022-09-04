# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1
**Criticar el código dado en base a patrónes y principios**

#### 🧐 Parte 2
**Realizar las CRC correspondientes.**

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**

# 1
Haría falta agregar dos clases más para especificar datos del paciente y del médico, ya que la clase existente es de la consulta médica y no permite agregar esos datos.
Tampoco hay getters ni setters sobre los atributos de la clase.

# 2

Las tarjetas CRC quedarían:

[
  {
    "name": "PatientInfo",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Almacenar los datos del paciente",
      "Validar datos del paciente"
    ],
    "collaborators": [
      ""
    ]
  },
  {
    "name": "DoctorInfo",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Almacenar los datos del doctor",
      "Validar datos del doctor"
    ],
    "collaborators": [
      ""
    ]
  },
  {
    "name": "AppointmentService",
    "superclasses": "",
    "subclasses": "",
    "type": 1,
    "responsibilities": [
      "Armar la consulta",
      "Validar datos de la consulta"
    ],
    "collaborators": [
      "DoctorInfo",
      "PatientInfo"
    ]
  }
]