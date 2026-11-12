using UnityEngine;

/// <summary>
/// Componente basico de diagnostico para comprobar la ejecucion inicial del proyecto.
/// Su unico proposito en esta Etapa 0 es verificar que el componente se ejecuta
/// correctamente en la escena activa y registrar informacion basica en la Consola.
/// No realiza comprobaciones exhaustivas de dependencias ni de configuracion.
/// </summary>
public class ProjectStartupCheck : MonoBehaviour
{
    /// <summary>
    /// Metodo invocado automaticamente por Unity antes de la primera actualizacion del cuadro (frame),
    /// siempre que el GameObject este activo y el componente habilitado.
    /// </summary>
    void Start()
    {
        // Se emite un unico mensaje informativo en la Consola de Unity pasando esta instancia como contexto.
        Debug.Log($"[Dkript2DAdventure] Comprobacion inicial de inicio: el componente responde activamente. Version de Unity en ejecucion: {Application.unityVersion}.", this);
    }
}
