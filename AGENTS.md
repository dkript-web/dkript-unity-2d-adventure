# 🎮 Reglas del Proyecto y Agentes: Dkript2DAdventure (Dkript Inc.)

Este archivo define las directrices obligatorias de desarrollo, calidad de código y diseño pedagógico para los agentes de IA y colaboradores en el proyecto **Dkript2DAdventure** (`dkript-unity-2d-adventure`).

---

## 1. Contexto y Audiencia Pedagógica
- **Proyecto:** Curso de desarrollo de videojuegos de plataformas 2D desde cero.
- **Autoría:** Joel Jonathan Perez Delgado / Dkript.
- **Audiencia:** Estudiantes y principiantes sin conocimientos previos de programación, Unity ni desarrollo de videojuegos.
- **Enfoque Pedagógico:** Avance estrictamente incremental por etapas. Cada etapa tiene un único propósito verificable. Se prohíbe anticipar mecánicas de etapas posteriores (no saltar a movimiento, física, combate o animaciones complejas antes de su etapa formal).

---

## 2. Gobernanza de Repositorios (Público vs Privado vs Local)

Para garantizar la integridad y el modelo de distribución de Dkript, el ecosistema se organiza en tres niveles independientes:

1. **Repositorio Público (`dkript-web/dkript-unity-2d-adventure`):**
   - **Propósito:** Alojar exclusivamente el proyecto funcional de Unity en C#, escenas, prefabs, assets necesarios y el `README.md` público con enlaces a los videos en YouTube.
   - **Exclusiones Obligatorias (`.gitignore`):** Queda estrictamente prohibido incluir en este repositorio las carpetas `Docs/`, `Research/`, `VideoScripts/`, `Prompts/` o cualquier material docente, soluciones o instrumentos de evaluación.
   - **Estrategia de Ramas:** Se utiliza `main` como rama principal estable y ramas dedicadas por hito funcional (`stage/00-setup`, `stage/01-sprites`, `stage/02-tilemaps`, `stage/03-collisions`).

2. **Repositorio Privado (`dkript-web/Dkript2DAdventure-Guides`):**
   - **Propósito:** Alojar las guías completas para estudiantes (`01_StudentGuide.md`), guías metodológicas para docentes (`02_TeacherGuide.md`), protocolos de troubleshooting (`03_Troubleshooting.md`), prácticas y rúbricas (`04_Practice.md`), soluciones docentes (`05_TeacherSolutions.md`), informes de validación (`06_Validation.md`), registros de etapa (`07_StageRecord.md`) e ilustraciones/assets pedagógicos complementarios.
   - **Visibilidad:** Estrictamente **PRIVATE** en GitHub.
   - **Estrategia de Ramas:** Se utiliza `main` como rama principal, organizando los contenidos por subdirectorios de etapa (`Docs/StageNN/`).

3. **Investigación y Almacenamiento Local (No Versionable en Remotos):**
   - Las transcripciones en bruto de canales de YouTube de terceros (`Research/YouTube/`), videos y audios descargados, y materiales sujetos a derechos de terceros se mantienen exclusivamente en almacenamiento local y **NUNCA** se envían a ningún repositorio remoto público ni privado.

### Checklist Preventivo Obligatorio Antes de Cada Commit / Push:
1. Identificar con certeza el repositorio de trabajo (`Dkript2DAdventure` vs `Dkript2DAdventure-Guides`).
2. Verificar la visibilidad remota esperada (Público vs Privado).
3. Inspeccionar `git status` y `git diff --cached` para garantizar cero filtraciones de documentación privada al repositorio público.
4. Confirmar que no se incluya un proyecto de Unity en el repositorio privado de guías.
5. Verificar que las referencias entre guías, ramas y videos sean exactas y consistentes.

---

## 3. Inviolabilidad de Código Aprobado y Arquitectura (Gobernanza Dkript)
- **Inviolabilidad de lo Aprobado:** Queda estrictamente prohibido alterar, eliminar, refactorizar o reescribir código, componentes, configuraciones de renderizado o estructuras de etapas previas ya verificadas.
- **Extender sin Romper:** Reutilizar antes de reemplazar; preservar antes de refactorizar.
- **Respeto a los Metadatos de Unity (`.meta`):**
  - **PROHIBIDO** fabricar, editar manualmente o eliminar archivos `.meta` de Unity o inventar GUIDs a mano.
  - La importación y generación de GUIDs debe dejarse exclusivamente en manos del motor de Unity.
- **No Alteración del Pipeline:** Respetar la configuración detectada de Universal Render Pipeline (URP 2D) y el nuevo Unity Input System. No cambiar dependencias ni paquetes en `Packages/manifest.json` sin autorización explícita.

---

## 4. Estándares de Código C# y Nomenclatura
- **Lenguaje del Código:** Clases, métodos, propiedades, eventos, variables y nombres de archivos se redactan exclusivamente en **inglés**.
- **Lenguaje de Comunicación y Comentarios:** Comentarios en el código, documentación, guías didácticas y mensajes dirigidos al alumno en la consola se redactan en **español**.
- **Convención de Capitalización:**
  - `PascalCase`: Nombres de clases, métodos, propiedades públicas/internas y enums.
  - `camelCase`: Parámetros de métodos y campos privados/protegidos.
- **Correspondencia Archivo-Clase:** Todo archivo de MonoBehaviour debe llamarse exactamente igual a la clase que declara (ejemplo: `ProjectStartupCheck.cs` declara `public class ProjectStartupCheck : MonoBehaviour`).
- **Claridad sobre Complejidad:** Evitar abreviaturas crípticas. Escribir código conciso, autoexplicativo y compatible con principiantes, sin patrones de arquitectura avanzada prematura (evitar singletons, service locators o inyección de dependencias compleja en etapas tempranas).

---

## 5. Estructura de Directorios del Proyecto
Todo el contenido propio del proyecto debe residir dentro de `Assets/_Project/` para aislarlo de los recursos predeterminados de Unity o de paquetes de terceros:
- `Assets/_Project/Scenes/`: Escenas de trabajo ordenadas por etapa.
- `Assets/_Project/Scripts/`: Lógica de programación (subdividida por módulos: `Core`, `Player`, `Environment`, etc.).
- `Assets/_Project/Sprites/`: Arte gráfico y texturas 2D.
- `Assets/_Project/Animations/`: Controladores de animación y clips.
- `Assets/_Project/Prefabs/`: Plantillas de GameObjects reutilizables.
- `Assets/_Project/Audio/`: Efectos de sonido y música.
- `Assets/_Project/UI/`: Elementos de interfaz de usuario.
- `Docs/`: Documentación local del curso (ignorada por Git en este repositorio).
- `Prompts/`: Archivo histórico de prompts pedagógicos (ignorado por Git).
- `VideoScripts/`: Escaletas y guiones de video formativos (ignorado por Git).
- `Research/`: Materiales de investigación técnica local (ignorado por Git).

---

## 6. Criterio de Veracidad y Validación de Pruebas
- **Honestidad Técnica:** No emitir afirmaciones de ejecución o pruebas que no se hayan ejecutado fehacientemente.
- **Pruebas en Entorno Sin Editor de Unity Interactivo:**
  - Si el agente no tiene una integración interactiva en tiempo de ejecución conectada a Unity Editor para ejecutar escenas en Play Mode, debe **declarar con total transparencia que la ejecución en Play Mode queda pendiente de realizarse en el Unity Editor por parte del usuario**.
  - No generar archivos de escena `.unity` redactados a mano en YAML: proporcionar siempre instrucciones precisas para que el usuario guarde y configure la escena directamente en el Unity Editor.
- **Calidad y Calibración:** Cada entrega debe registrar explícitamente:
  1. Comprobaciones estáticas realizadas con éxito.
  2. Pasos exactos que el usuario debe realizar en el editor de Unity.
  3. Resultado esperado exacto observable en pantalla y consola.
  4. Criterios de aceptación para considerar cerrada la etapa.
