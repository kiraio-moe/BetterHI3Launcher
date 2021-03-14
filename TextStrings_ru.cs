﻿using System.Windows;

namespace BetterHI3Launcher
{
    public partial class MainWindow : Window
    {
        private void TextStrings_Russian()
        {
            textStrings["version"] = "Версия";
            textStrings["launcher_version"] = "Версия лаунчера";
            textStrings["binary_prefixes"] = "КМГТПЭЗЙ";
            textStrings["binary_prefix_byte"] = "б";
            textStrings["bytes_per_second"] = "Б/с";
            textStrings["outdated"] = "Устарело";
            textStrings["enabled"] = "Включен";
            textStrings["disabled"] = "Выключен";
            textStrings["button_download"] = "Загрузить";
            textStrings["button_downloading"] = "Загрузка";
            textStrings["button_update"] = "Обновить";
            textStrings["button_pause"] = "Приостановить";
            textStrings["button_launch"] = "Запустить";
            textStrings["button_options"] = "Опции";
            textStrings["button_resume"] = "Возобновить";
            textStrings["button_confirm"] = "Принять";
            textStrings["button_cancel"] = "Отмена";
            textStrings["button_github"] = "Перейти в репозиторий GitHub";
            textStrings["label_server"] = "Сервер";
            textStrings["label_mirror"] = "Зеркало";
            textStrings["label_log"] = "Показать лог";
            textStrings["contextmenu_downloadcache"] = "Загрузить кэш";
            textStrings["contextmenu_uninstall"] = "Удалить игру";
            textStrings["contextmenu_fixsubs"] = "Исправить субтитры";
            textStrings["contextmenu_download_type"] = "Изменить тип загрузки";
            textStrings["contextmenu_game_settings"] = "Управление настройками игры";
            textStrings["contextmenu_customfps"] = "Задать своё ограничение FPS";
            textStrings["contextmenu_customresolution"] = "Задать своё разрешение";
            textStrings["contextmenu_resetgamesettings"] = "Сбросить настройки игры";
            textStrings["contextmenu_web_profile"] = "Перейти в веб-профиль";
            textStrings["contextmenu_feedback"] = "Отправить отзыв";
            textStrings["contextmenu_changelog"] = "История изменений";
            textStrings["contextmenu_language"] = "Язык";
            textStrings["contextmenu_language_system"] = "Системный";
            textStrings["contextmenu_language_english"] = "Английский";
            textStrings["contextmenu_language_russian"] = "Русский";
            textStrings["contextmenu_language_spanish"] = "Испанский";
            textStrings["contextmenu_language_portuguese"] = "Португальский";
            textStrings["contextmenu_language_german"] = "Немецкий";
            textStrings["contextmenu_language_vietnamese"] = "Вьетнамский";
            textStrings["contextmenu_language_contribute"] = "Хотите помочь?";
            textStrings["contextmenu_about"] = "О лаунчере";
            textStrings["progresstext_error"] = "Ошибочка вышла :^(";
            textStrings["progresstext_verifying"] = "Проверка игровых файлов...";
            textStrings["progresstext_cleaningup"] = "Убираюсь за собой...";
            textStrings["progresstext_checkingupdate"] = "Проверка на наличие обновления...";
            textStrings["progresstext_downloadsize"] = "Размер загрузки";
            textStrings["progresstext_downloaded"] = "Загружено {0}/{1} ({2})";
            textStrings["progresstext_eta"] = "Расчётное время: {0}";
            textStrings["progresstext_unpacking_1"] = "Распаковка игровых файлов...";
            textStrings["progresstext_unpacking_2"] = "Распаковка игрового файла {0}/{1}...";
            textStrings["progresstext_uninstalling"] = "Удаление игры...";
            textStrings["progresstext_mirror_connect"] = "Подключение к зеркалу...";
            textStrings["progresstext_initiating_download"] = "Загрузка начинается...";
            textStrings["progresstext_updating_launcher"] = "Обновление лаунчера...";
            textStrings["introbox_title"] = "Добро пожаловать в Better Honkai Impact 3rd launcher!";
            textStrings["introbox_msg_1"] = "!!! ВАЖНО, СТОИТ ПРОЧИТАТЬ !!!";
            textStrings["introbox_msg_2"] = "Похоже, вы впервые запустили этот лаунчер. Во-первых, я рад, что вы решили попробовать его, так что не стесняйтесь высказывать своё мнение по поводу него.\nВо-вторых, если вы вдруг использовали официальный лаунчер для обновления игры и ещё её не запустили (до момента захода на мостик) - этот лаунчер использовать не стоит. Иначе он может определить версию игры как старую и заставить загружать игру снова.\n\nПрочитали всё это? Замечательно! Если игра уже установлена, то просто нажмите \"Загрузить\" и выберите папку с игрой. Лаунчер её найдёт и ничего скачивать заново будет не нужно.";
            textStrings["downloadcachebox_msg"] = "Здесь вы можете загрузить игровой кэш.\nВыберите \"Полный кэш\", если игра застревает на \"Updating event resources\".\nВыберите \"Числовые файлы\", если игра застревает на \"Updating settings\".\nУчтите, что на данный момент нет способа автоматически загружать новейший кэш, а потому нам приходится загружать его вручную на зеркало.\nИспользуемое зеркало: {0}.\nДата обновления кэша: {1}.\nОтветственный за зеркало: {2}.";
            textStrings["downloadcachebox_button_full_cache"] = "Полный кэш";
            textStrings["downloadcachebox_button_numeric_files"] = "Числовые файлы";
            textStrings["fpsinputbox_title"] = "Задайте ограничение FPS";
            textStrings["fpsinputbox_label_combatfps"] = "FPS во время игры";
            textStrings["fpsinputbox_label_menufps"] = "FPS в меню";
            textStrings["resolutioninputbox_title"] = "Задайте разрешение";
            textStrings["resolutioninputbox_label_width"] = "Ширина";
            textStrings["resolutioninputbox_label_height"] = "Высота";
            textStrings["resolutioninputbox_label_fullscreen"] = "Полный экран";
            textStrings["changelogbox_title"] = "История изменений";
            textStrings["changelogbox_msg"] = "Better Honkai Impact 3rd Launcher только что стал ещё лучше. Вот что произошло:";
            textStrings["aboutbox_msg"] = "Ну он и правда лучше же, верно? :^)\nДанный проект был сделан с целью улучшить игровой опыт множества капитанов.\nОн не связан с miHoYo и исходный код полностью открыт.\nЛюбой отзыв глубоко приветствуется.\nОсобая благодарность данным добровольцам GitHub:\nSinsOfSeven - Возможность задавать своё разрешение игры\nProxy-E23 - Перевод лаунчера на испанский язык\nSpookyKisuy - Перевод лаунчера на португальский язык\nbulawin1 - Перевод лаунчера на немецкий язык\nKorewaLidesu - Перевод лаунчера на вьетнамский язык";
            textStrings["msgbox_download_cache_1_msg"] = "Сейчас начнётся загрузка полного кэша.";
            textStrings["msgbox_download_cache_2_msg"] = "Сейчас начнётся загрузка кэша числовых файлов.";
            textStrings["msgbox_download_cache_3_msg"] = "Приблизительный размер: {0}.\nПродолжить?";
            textStrings["msgbox_genericerror_title"] = "Ошибка";
            textStrings["msgbox_genericerror_msg"] = "Произошла ошибка.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_neterror_title"] = "Сетевая ошибка";
            textStrings["msgbox_neterror_msg"] = "Произошла ошибка подключения к серверу:\n{0}";
            textStrings["msgbox_verifyerror_title"] = "Ошибка проверки целостности файла";
            textStrings["msgbox_verifyerror_1_msg"] = "Произошла ошибка при загрузке, попробуйте снова.";
            textStrings["msgbox_verifyerror_2_msg"] = "Произошла ошибка при загрузке, файл может быть повреждён.\nВсё равно продолжить?";
            textStrings["msgbox_starterror_title"] = "Ошибка запуска";
            textStrings["msgbox_starterror_msg"] = "Произошла ошибка запуска лаунчера:\n{0}";
            textStrings["msgbox_launcherdownloaderror_msg"] = "Произошла ошибка загрузки лаунчера:\n{0}";
            textStrings["msgbox_gamedownloaderror_title"] = "Ошибка загрузки игровых файлов";
            textStrings["msgbox_gamedownloaderror_msg"] = "Произошла ошибка загрузки игровых файлов.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_installerror_msg"] = "Произошла ошибка установки игровых файлов.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_installerror_title"] = "Ошибка установки";
            textStrings["msgbox_process_start_error_msg"] = "Произошла ошибка запуска процесса.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_update_title"] = "Уведомление об обновлении";
            textStrings["msgbox_install_msg"] = "Игра будет установлена по пути:\n{0}\nПродолжить установку?";
            textStrings["msgbox_install_title"] = "Уведомление об установке";
            textStrings["msgbox_installdirerror_msg"] = "Произошла ошибка выбора игрового пути:\n{0}";
            textStrings["msgbox_installdirerror_title"] = "Неверный путь установки";
            textStrings["msgbox_abort_1_msg"] = "Вы точно уверены, что хотите отменить загрузку и выйти?";
            textStrings["msgbox_abort_2_msg"] = "Прогресс не будет сохранён.";
            textStrings["msgbox_abort_3_msg"] = "Прогресс будет сохранён.";
            textStrings["msgbox_abort_title"] = "Запрос на отмену";
            textStrings["msgbox_registryerror_msg"] = "Произошла ошибка доступа к реестру.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_registryerror_title"] = "Ошибка реестра";
            textStrings["msgbox_registryempty_1_msg"] = "Нужное значение в реестре отсутствует.";
            textStrings["msgbox_registryempty_2_msg"] = "Вы уже запускали игру?";
            textStrings["msgbox_registryempty_3_msg"] = "Попробуйте изменить настройки видео в игре (выключить полный экран, изменить пресет видео и т. д.).";
            textStrings["msgbox_uninstall_1_msg"] = "Вы уверены, что хотите удалить игру?";
            textStrings["msgbox_uninstall_2_msg"] = "Вы точно уверены, что хотите удалить игру? :^(";
            textStrings["msgbox_uninstall_3_msg"] = "Удалить также и настройки игры с кэшем?";
            textStrings["msgbox_uninstall_4_msg"] = "Нельзя удалить игру, пока лаунчер находится внутри игровой папки. Переместите лаунчер из папки и попробуйте снова.";
            textStrings["msgbox_uninstall_title"] = "Удаление";
            textStrings["msgbox_uninstallerror_msg"] = "Произошла ошибка удаления игры:\n{0}";
            textStrings["msgbox_uninstallerror_title"] = "Ошибка удаления";
            textStrings["msgbox_download_type_1_msg"] = "Будет изменён тип загрузки внутриигровых ресурсов в надежде исправить печально известную проблему с бесконечной загрузкой в игре.\nЕсли с первого раза не помогает, попробуйте ещё раз.\nПродолжить?";
            textStrings["msgbox_download_type_2_msg"] = "Значение ResourceDownloadType до: {0}.\nЗначение ResourceDownloadType после: {1}.";
            textStrings["msgbox_fixsubs_1_msg"] = "Будет произведена попытка исправить субтитры к видео (и гача баннеры). Убедитесь, что все видеофайлы были загружены в игре.\nПродолжить?";
            textStrings["msgbox_fixsubs_2_msg"] = "Распаковка субтитров к видео {0}/{1}...";
            textStrings["msgbox_fixsubs_3_msg"] = "Проверка файла субтитров {0}/{1}...";
            textStrings["msgbox_fixsubs_4_msg"] = "Субтитры распакованы к {0} файлам видео.";
            textStrings["msgbox_fixsubs_5_msg"] = "Исправлено {0} файлов субтитров.";
            textStrings["msgbox_fixsubs_6_msg"] = "Не был исправлен ни один файл субтитров. Субтитры либо ещё не загружены, либо уже исправлены.";
            textStrings["msgbox_customfps_1_msg"] = "Значения не должно быть пустым.";
            textStrings["msgbox_customfps_2_msg"] = "Значения не должно равняться нулю или быть отрицательным.";
            textStrings["msgbox_customfps_3_msg"] = "Значения ниже 30 не рекомендуются. Продолжить?";
            textStrings["msgbox_customfps_4_msg"] = "Ограничение FPS во время игры и в меню успешно установлено на {0} и {1} соответственно.";
            textStrings["msgbox_customresolution_1_msg"] = "Не рекомендуется устанавливать высоту больше, чем ширину.\nПродолжить?";
            textStrings["msgbox_customresolution_2_msg"] = "Разрешение {0}x{1} успешно установлено, полный экран {2}.";
            textStrings["msgbox_resetgamesettings_1_msg"] = "Будут сброшены все настройки игры, сохранённые в реестре.\nИспользуйте это только в том случае, если возникли проблемы с игрой!\nПродолжить?";
            textStrings["msgbox_resetgamesettings_2_msg"] = "Эта операция необратима. Вы уверены, что хотите продолжить?";
            textStrings["msgbox_resetgamesettings_3_msg"] = "Настройки игры были сброшены.";
            textStrings["msgbox_extractskip_title"] = "Уведомление о пропущенных файлах";
            textStrings["msgbox_extractskip_msg"] = "Распаковка завершена, однако некоторые файлы не получилось распаковать. Возможно, придётся сделать это вручную.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_noexe_title"] = "Нет исполняемого файла игры";
            textStrings["msgbox_noexe_msg"] = "Исполняемый файл игры не может быть найден :^(\nПопробуйте переустановить игру.";
            textStrings["msgbox_installexisting_msg"] = "Похоже, что игра уже была установлена по пути:\n{0}\nИспользовать этот путь?";
            textStrings["msgbox_installexistinginvalid_msg"] = "По данному пути не найдено верного клиента игры. Этот лаунчер поддерживает только клиенты Global и SEA серверов.";
            textStrings["msgbox_install_existing_no_local_version_msg"] = "Не удалось определить установленную версию.\nОбновлена ли уже игра? Пожалуйста, ответьте правильно!\nВыбрав \"Да\", можно будет запустить игру.\nВыбрав \"Нет\", нужно будет загрузить игру.";
            textStrings["msgbox_notice_title"] = "Уведомление";
            textStrings["msgbox_novideodir_msg"] = "Папка с видео не может быть найдена.\nПопробуйте переустановить игру.";
            textStrings["msgbox_mirrorinfo_msg"] = "Используйте зеркало только в том случае, если не получается загрузить игру с официальных серверов miHoYo.\nУчтите, что зеркало обновляется вручную.\nПродолжить?";
            textStrings["msgbox_updatecheckerror_msg"] = "Произошла ошибка проверки обновления.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_updatecheckerror_title"] = "Ошибка проверки обновления";
            textStrings["msgbox_gamedownloadmirrorold_msg"] = "Похоже, что версия игры на серверах miHoYo новее той, что загружена на зеркало.\nЗагружать старую версию нет смысла, попросите автора загрузить новую версию на зеркало.";
            textStrings["msgbox_gamedownloadpaused_msg"] = "Игра ещё не была загружена до конца. Изменение сервера или зеркала приведёт к сбросу прогресса загрузки.\nПродолжить?";
            textStrings["msgbox_gamedownloadmirrorerror_msg"] = "Произошла ошибка загрузки с зеркала.\nДля дополнительной информации посмотрите лог.";
            textStrings["msgbox_install_little_space_msg"] = "Свободного пространства на устройстве потенциально мало, рекомендуется освободить место или установка может завершиться неудачей.\nПродолжить?";
            textStrings["msgbox_install_wrong_drive_type_msg"] = "На данное устройство установить нельзя.";
            textStrings["msgbox_mirror_error_msg"] = "Ошибка зеркала. Попросите ответственного за зеркало разобраться с этим.\nСообщение: {0}";
            textStrings["msgbox_net_version_old_msg"] = "Этот лаунчер требует установленного .NET Framework версии 4.6 или новее.";
            textStrings["msgbox_language_msg"] = "Язык изменится на {0} и лаунчер будет перезапущен.\nПродолжить?";
            textStrings["msgbox_no_internet_msg"] = "Не могу подключиться к интернету. Вы подключены к сети?";
        }
    }
}