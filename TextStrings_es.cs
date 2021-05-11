﻿using System.Windows;

namespace BetterHI3Launcher
{
    public partial class MainWindow : Window
    {
        private void TextStrings_Spanish()
        {
            textStrings["version"] = "Versión";
            textStrings["launcher_version"] = "Versión del launcher";
            textStrings["outdated"] = "Desactualizado";
            textStrings["enabled"] = "Activada";
            textStrings["disabled"] = "Desactivada";
            textStrings["button_yes"] = "Sí";
            textStrings["button_download"] = "Descargar";
            textStrings["button_downloading"] = "Descargando";
            textStrings["button_running"] = "Ejecutando";
            textStrings["button_update"] = "Actualizar";
            textStrings["button_pause"] = "Pausar";
            textStrings["button_launch"] = "Iniciar";
            textStrings["button_options"] = "Opciones";
            textStrings["button_resume"] = "Reanudar";
            textStrings["button_confirm"] = "Confirmar";
            textStrings["button_cancel"] = "Cancelar";
            textStrings["button_github"] = "Ir al repositorio de GitHub";
            textStrings["button_generate"] = "Generar";
            textStrings["label_server"] = "Servidor";
            textStrings["label_mirror"] = "Espejo";
            textStrings["label_log"] = "Mostrar log";
            textStrings["contextmenu_downloadcache"] = "Descargar cache";
            textStrings["contextmenu_repair"] = "Reparar los archivos del juego";
            textStrings["contextmenu_move"] = "Mover los archivos del juego";
            textStrings["contextmenu_uninstall"] = "Desinstalar juego";
            textStrings["contextmenu_fixsubs"] = "Corregir subtítulos";
            textStrings["contextmenu_download_type"] = "Restablecer el tipo de descarga";
            textStrings["contextmenu_game_settings"] = "Administrar configuración del juego";
            textStrings["contextmenu_customfps"] = "Establecer límite de FPS personalizado";
            textStrings["contextmenu_customresolution"] = "Establecer resolución personalizada";
            textStrings["contextmenu_resetgamesettings"] = "Restablecer configuración del juego";
            textStrings["contextmenu_web_profile"] = "Abrir perfil en el sitio web";
            textStrings["contextmenu_feedback"] = "Enviar comentarios";
            textStrings["contextmenu_changelog"] = "Mostrar changelog";
            textStrings["contextmenu_language"] = "Idioma";
            textStrings["contextmenu_language_system"] = "Predeterminado del sistema";
            textStrings["contextmenu_language_english"] = "Inglés";
            textStrings["contextmenu_language_russian"] = "Ruso";
            textStrings["contextmenu_language_spanish"] = "Español";
            textStrings["contextmenu_language_portuguese"] = "Portugués";
            textStrings["contextmenu_language_german"] = "Alemán";
            textStrings["contextmenu_language_vietnamese"] = "Vietnamita";
            textStrings["contextmenu_language_serbian"] = "Serbio";
            textStrings["contextmenu_language_contribute"] = "¿Quieres ayudar?";
            textStrings["contextmenu_sounds"] = "Sonidos";
            textStrings["contextmenu_about"] = "Acerca de";
            textStrings["progresstext_error"] = "¡Ups! Algo salió mal :^(";
            textStrings["progresstext_verifying_files"] = "Verficando archivos del juego...";
            textStrings["progresstext_verifying_file"] = "Verficando archivo del juego {0}/{1}...";
            textStrings["progresstext_cleaningup"] = "Limpiando...";
            textStrings["progresstext_checkingupdate"] = "Buscando actualizaciones...";
            textStrings["progresstext_downloadsize"] = "Tamaño de la descarga";
            textStrings["progresstext_downloaded"] = "Descargado {0}/{1} ({2})";
            textStrings["progresstext_downloading_file"] = "Archivo descargando {0}/{1}...";
            textStrings["progresstext_eta"] = "Tiempo estimado: {0}";
            textStrings["progresstext_unpacking_1"] = "Descomprimiendo archivos del juego...";
            textStrings["progresstext_unpacking_2"] = "Descomprimiendo archivo del juego {0}/{1}...";
            textStrings["progresstext_moving_files"] = "Moviendo archivos del juego...";
            textStrings["progresstext_uninstalling"] = "Desinstalando juego...";
            textStrings["progresstext_mirror_connect"] = "Conectando al espejo...";
            textStrings["progresstext_initiating_download"] = "Iniciando descarga...";
            textStrings["progresstext_updating_launcher"] = "Actualizando launcher...";
            textStrings["progresstext_generating_hash"] = "Generando hash para archivo {0}/{1}...";
            textStrings["progresstext_zipping"] = "Añadiendo archivo {0}/{1} al archivo ZIP...";
            textStrings["progresstext_fetching_hashes"] = "Obteniendo hashes de archivos...";
            textStrings["introbox_title"] = "¡Bienvenido a Better Honkai Impact 3rd launcher!";
            textStrings["introbox_msg"] = "Al parecer esta es la primera vez que usa este Launcher. Me alegra que haya decidido probarlo, en caso de que quiera darnos su opinión, no dude en hacerlo dando clic en el botón \"Opciones\"y seleccionando \"Enviar comentarios\".\nSi ya ha instalado el juego, presiona el botón \"Descargar\" y selecciona la ubicación donde lo ha instalado. TEl launcher detectara la instalación y no sera necesario descargarlo de nuevo.";
            textStrings["downloadcachebox_msg"] = "Seleccione si desea descargar la caché completa o solo los archivos numéricos.\nElija \"Caché completa\" Si presenta problemas al momento de actualizar los recursos del evento.\nElija \"Archivos numéricos\" si tiene problemas para actualizar la configuración (bucle de update settings).\nTenga en cuenta que actualmente no hay forma de recuperar automáticamente la última caché y tenemos que cargarla manualmente a un espejo.\nEspejo en uso: {0}.\nÚltima actualización de la caché: {1}.\nActual encargado del espejo {2}.";
            textStrings["downloadcachebox_button_full_cache"] = "Caché completa";
            textStrings["downloadcachebox_button_numeric_files"] = "Archivos numericos";
            textStrings["repairbox_msg"] = "Esto comprobará todos los archivos del juego e intentará repararlos si alguno está roto. Esto podría tomar un tiempo.\n¿Continuar?\nEspejos disponibles: {0}.\nActual encargado del espejo {1}.";
            textStrings["fpsinputbox_title"] = "Asigne limite maximo de FPS";
            textStrings["fpsinputbox_label_combatfps"] = "FPS en el juego";
            textStrings["fpsinputbox_label_menufps"] = "FPS en el menú";
            textStrings["resolutioninputbox_title"] = "Asigne una resolución personalizada";
            textStrings["resolutioninputbox_label_width"] = "Ancho";
            textStrings["resolutioninputbox_label_height"] = "Altura";
            textStrings["changelogbox_title"] = "Log de cambios";
            textStrings["changelogbox_1_msg"] = "Better Honkai Impact 3rd Launcher se ha vuelto mejor. Esto es lo que paso:";
            textStrings["changelogbox_2_msg"] = "Cargando el changelog...";
            textStrings["changelogbox_3_msg"] = "No se pudo cargar el changelog.";
            textStrings["aboutbox_msg"] = "Bueno, es mucho más avanzado, ¿no?:^)\nEste proyecto se creo con la intención de que los capitanes tuvieran una mejor experiencia con el juego..\nBetterHI3Launcher no está afiliado a miHoYo y es completamente de código abierto..\nAgradecemos mucho todo el feedback.\nUn agradecimiento especial a los contribuidores de GitHub:\nSinsOfSeven - Contribución de resolución personalizada\nProxy-E23 - Traducción al idioma español\nSpookyKisuy - Traducción al idioma portugués\nbulawin1, Vrontis - Traducción al idioma alemán\nKorewaLidesu - Traducción al idioma vietnamita\nSm1leAway - Traducción al idioma sérvia";
            textStrings["msgbox_genericerror_msg"] = "Ha ocurrido un error.\nPara mas informacion, consultar el log.";
            textStrings["msgbox_neterror_title"] = "Error de red";
            textStrings["msgbox_neterror_msg"] = "Error al conectarse al servidor:\n{0}";
            textStrings["msgbox_verifyerror_title"] = "Error al validar el archivo";
            textStrings["msgbox_verifyerror_1_msg"] = "Ocurrió un error durante la descarga. Vuelva a intentarlo.";
            textStrings["msgbox_verifyerror_2_msg"] = "Ocurrió un error durante la descarga. El archivo puede estar dañado.\nContinuar de todos modos?";
            textStrings["msgbox_starterror_title"] = "Error de inicio";
            textStrings["msgbox_starterror_msg"] = "Ocurrió un error al iniciar el launcher:\n{0}";
            textStrings["msgbox_launcherdownloaderror_msg"] = "Ocurrió un error al descargar el launcher:\n{0}";
            textStrings["msgbox_gamedownloaderror_title"] = "Error al descargar los archivos del juego";
            textStrings["msgbox_gamedownloaderror_msg"] = "Se produjo un error al instalar los archivos del juego.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_installerror_msg"] = "Se produjo un error al instalar los archivos del juego.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_installerror_title"] = "Error de instalación";
            textStrings["msgbox_process_start_error_msg"] = "Se produjo un error al iniciar el proceso.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_update_title"] = "Aviso de actualización";
            textStrings["msgbox_install_msg"] = "El juego se instalará en:\n{0}\n¿Continuar?";
            textStrings["msgbox_install_title"] = "Aviso de instalación";
            textStrings["msgbox_installdirerror_msg"] = "Ocurrió un error al seleccionar el directorio de instalación del juego.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_installdirerror_title"] = "Directorio inválido";
            textStrings["msgbox_abort_1_msg"] = "¿Está seguro de que desea cancelar la descarga y cerrar el launcher?";
            textStrings["msgbox_abort_2_msg"] = "El progreso no sera guardado.";
            textStrings["msgbox_abort_3_msg"] = "El progreso sera guardado.";
            textStrings["msgbox_abort_title"] = "Abortar solicitud";
            textStrings["msgbox_registryerror_msg"] = "Se produjo un error al acceder al registro.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_registryerror_title"] = "Error de registro";
            textStrings["msgbox_registryempty_1_msg"] = "No existe ningún valor para modificar en el registro.";
            textStrings["msgbox_registryempty_2_msg"] = "¿Ya ejecutó el juego?";
            textStrings["msgbox_registryempty_3_msg"] = "Intenta cambiar la configuración de vídeo en el juego primero (desactivando la fullscreen, cambiando el preajuste de vídeo, etc).";
            textStrings["msgbox_download_cache_1_msg"] = "La caché completa está a punto de descargarse.";
            textStrings["msgbox_download_cache_2_msg"] = "La caché de archivos numéricos está a punto de descargarse.";
            textStrings["msgbox_download_cache_3_msg"] = "Tamaño de descarga: {0}.\n¿Continuar?";
            textStrings["msgbox_repair_1_msg"] = "La versión del juego instalada difiere de la información de reparación en el servidor. Debido a que tenemos que actualizar esta información manualmente, es posible que no esté disponible durante algún tiempo.\nPor favor, inténtelo de nuevo más tarde.";
            textStrings["msgbox_repair_2_msg"] = "Ningún archivo necesita reparaciones.";
            textStrings["msgbox_repair_3_msg"] = "Encontrado {0} archivo(s) corrupto(s)/perdido(s). Necesitan ser descargados de nuevo para ser reparados.\nDebido a que la tecnología es increíble, solo se descargarán los archivos necesarios.\nTamaño de descarga: {1}.\n¿Continuar?";
            textStrings["msgbox_repair_4_msg"] = "{0} Archivo(s) reparado con éxito.";
            textStrings["msgbox_repair_5_msg"] = "{0} Archivo(s) no pudieron ser reparado(s). Considera revisar tu dispositivo de almacenamiento, puede estar defectuoso.";
            textStrings["msgbox_move_1_msg"] = "El juego se moverá a:\n{0}\n¿Continuar?";
            textStrings["msgbox_move_2_msg"] = "No se puede mover el juego dentro del directorio de juegos actual.";
            textStrings["msgbox_move_3_msg"] = "No se puede mover el juego mientras el launcher está dentro del directorio del juego. Mueva el launcher fuera del directorio y vuelva a intentarlo.";
            textStrings["msgbox_move_title"] = "Mover";
            textStrings["msgbox_move_error_title"] = "Mover error";
            textStrings["msgbox_uninstall_1_msg"] = "¿Estás seguro de que deseas desinstalar el juego?";
            textStrings["msgbox_uninstall_2_msg"] = "¿Estás realmente seguro de que quieres desinstalar el juego? :^(";
            textStrings["msgbox_uninstall_3_msg"] = "¿Eliminar también la configuración y los archivos de la caché del juego?";
            textStrings["msgbox_uninstall_4_msg"] = "No se puede desinstalar el juego mientras el launcher está dentro del directorio del juego. Mueva el launcher fuera del directorio y vuelva a intentarlo.";
            textStrings["msgbox_uninstall_title"] = "Desinstalar";
            textStrings["msgbox_uninstallerror_msg"] = "Ocurrio un error al desinstalar el juego.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_uninstallerror_title"] = "Error de desinstalación";
            textStrings["msgbox_download_type_1_msg"] = "Esto restablecerá el tipo de descarga de recursos del juego en un intento de solucionar el infame bucle de actualización que no permite ingresar al juego.\n¿Continar?";
            textStrings["msgbox_download_type_2_msg"] = "Se restableció el tipo de descarga. Inicie el juego y seleccione \"HD assets\".";
            textStrings["msgbox_download_type_3_msg"] = "El tipo de descarga ya se ha restablecido. Inicie el juego y seleccione \"HD assets\".";
            textStrings["msgbox_fixsubs_1_msg"] = "Esto intentará arreglar los subtítulos CG (y los banners de gacha). Asegúrate de tener ya descargado todos los CG del juego.\n¿Continuar?";
            textStrings["msgbox_fixsubs_2_msg"] = "Descomprimiendo el archivo de subtítulos {0}/{1}...";
            textStrings["msgbox_fixsubs_3_msg"] = "Comprobando archivo de subtítulos {0}/{1}...";
            textStrings["msgbox_fixsubs_4_msg"] = "Subtítulos descomprimidos para {0} CG.";
            textStrings["msgbox_fixsubs_5_msg"] = "Se corrigieron {0} archivos de subtítulos.";
            textStrings["msgbox_fixsubs_6_msg"] = "No se corrigieron los archivos de los subtítulos. No se descargaron todavía o ya se han solucionado.";
            textStrings["msgbox_customfps_1_msg"] = "Los valores no deben estar vacíos.";
            textStrings["msgbox_customfps_2_msg"] = "Los valores no deben ser cero o negativos.";
            textStrings["msgbox_customfps_3_msg"] = "No se recomiendan valores inferiores a 30. ¿Continuar?";
            textStrings["msgbox_customfps_4_msg"] = "El límite de FPS en el juego y en el menú se estableció correctamente en {0} y {1} respectivamente.";
            textStrings["msgbox_customresolution_1_msg"] = "No se recomienda que la altura sea mayor que la anchura.\n¿Continuar?";
            textStrings["msgbox_customresolution_2_msg"] = "Resolución se estableció correctamente en {0}x{1} con la fullscreen {2}.";
            textStrings["msgbox_resetgamesettings_1_msg"] = "Esto borrará todas las configuraciones del juego almacenadas en el registro.\n¡Usa esto solo si tienes problemas con el juego!\n¿Continuar?";
            textStrings["msgbox_resetgamesettings_2_msg"] = "Esta acción es irreversible. ¿Estás seguro que quieres hacer esto?";
            textStrings["msgbox_resetgamesettings_3_msg"] = "La configuración del juego se ha borrado del registro.";
            textStrings["msgbox_extractskip_title"] = "Aviso de omisión de archivo";
            textStrings["msgbox_extractskip_msg"] = "El desempaquetado finalizó, pero algunos archivos no se pudieron descomprimir. Es posible que desee descomprimirlos manualmente.\nPara obtener más información, consulte el log.";
            textStrings["msgbox_noexe_title"] = "Ningún ejecutable del juego";
            textStrings["msgbox_noexe_msg"] = "No se puede encontrar el ejecutable del juego.\nIntenta reinstalar el juego.";
            textStrings["msgbox_nodir_title"] = "Ningún directorio del juego";
            textStrings["msgbox_nodir_msg"] = "No se puede encontrar el directorio del juego.\nIntenta reinstalar el juego.";
            textStrings["msgbox_installexisting_msg"] = "Parece que el juego ya se ha instalado en:\n{0}\n¿Usas este directorio?";
            textStrings["msgbox_installexistinginvalid_msg"] = "El directorio seleccionado no contiene una instalación válida del juego. Este launcher solo admite clientes Global y SEA.";
            textStrings["msgbox_install_existing_no_local_version_msg"] = "No se pudo determinar la versión local.\n¿Tu juego ya está actualizado? ¡Elige con cuidado!\nSeleccionar \"Sí\" hará que puedas iniciar el juego.\nSeleccionar \"No\" hará que tengas que descargar el juego.";
            textStrings["msgbox_notice_title"] = "Aviso";
            textStrings["msgbox_novideodir_msg"] = "No se puede encontrar la carpeta de video.\nIntenta reinstalar el juego.";
            textStrings["msgbox_mirrorinfo_msg"] = "Usa este espejo solo si no puedes descargar el juego a través de los servidores oficiales de miHoYo.\nTen en cuenta que se actualiza manualmente.\n¿Continuar?";
            textStrings["msgbox_updatecheckerror_msg"] = "Ocurrió un error al buscar actualizaciones.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_updatecheckerror_title"] = "Error al comprobar actualización";
            textStrings["msgbox_gamedownloadmirrorold_msg"] = "Parece que la versión del juego en los servidores de miHoYo es más reciente que la del espejo.\nNo es necesario descargar una versión desactualizada, pídale al encargado del espejo que cargue la versión mas reciente.";
            textStrings["msgbox_gamedownloadpaused_msg"] = "El juego aún no se ha terminado de descargar por completo. Cambiar el servidor o el espejo reiniciara el progreso de la descarga.\n¿Continuar?";
            textStrings["msgbox_gamedownloadmirrorerror_msg"] = "Se produjo un error durante la descarga desde el espejo.\nPara obtener más información, consultar el log.";
            textStrings["msgbox_install_little_space_msg"] = "Es posible que no haya suficiente espacio libre en el dispositivo seleccionado, se recomienda liberar algo de espacio o la instalación puede resultar en un error.\n¿Continuar?";
            textStrings["msgbox_install_wrong_drive_type_msg"] = "No se puede instalar en el dispositivo seleccionado.";
            textStrings["msgbox_move_little_space_msg"] = "Es posible que no haya suficiente espacio libre en el dispositivo seleccionado, se recomienda liberar algo de espacio o moverlo puede resultar en un error.\n¿Continuar?";
            textStrings["msgbox_move_wrong_drive_type_msg"] = "No se puede mover al dispositivo seleccionado.";
            textStrings["msgbox_mirror_error_msg"] = "Hay un error con el espejo. Pídale al encargado del espejo que llegue al fondo de esto.\nMensaje: {0}";
            textStrings["msgbox_net_version_old_msg"] = "Este launcher requiere la instalación de .NET Framework 4.6.1 o posterior.";
            textStrings["msgbox_language_msg"] = "El idioma se cambiará a {0} y el launcher se reiniciará.\n¿Continuar?";
            textStrings["msgbox_conn_bp_error_msg"] = "No se puede conectar a Bp Network:";
            textStrings["msgbox_conn_mihoyo_error_msg"] = "No se puede conectar a los servidores miHoYo:";
        }
    }
}