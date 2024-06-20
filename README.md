# Cute-Cells

Проект создан для изучения DoTween и Addressable. 
Вся анимация сделана с помощью DoTween. 
Переход между уровнями сделан с помощью Addressable, все уровни и контент добавлены в бандлы.  
Корректировки: Убрал продгузку с сервера чтобы можно было без дополнительных действий проверять работоспособность игры.

Подгрузка бандлов с локального сервера с помощью Addressable  

-) Для работы загрузки материалов с помощью Addressable с локального сервера необходимо зайти в Windows/AssetManagement/Addressables/Hosting и запустить локальный сервер.  
-) В Windows/AssetManagement/Addressables/Profiles в поле Remore выбрать Editor Hosted. В Windows/AssetManagement/Addressables/Settings в поле Content Update/Build & Load Path выставляем Remote.  
-) Далее в Windows/AssetManagement/Addressables/Groupes пересобрать все бандлы (они перезапишутся под новый порт). Чтобы всё работало на телефоне, нужно чтобы телефон был подключен к той же подсети, на которой работает компьютер с запущенным локальным сервером (например к одной Wi-Fi сети).

P.S. Иногда на телефоне может не работать подключение к локальному серверу из-за блокировки порта. Поэтому для крупных проектов необходимо выделить отдельный сервер с белым IP и пробросить порт, который будет задан при настройке путей для загрузки бандлов.


Для визуала использовались следующие ассеты:

Cute Cartoon Mobile GUI:
https://assetstore.unity.com/packages/2d/gui/cute-cartoon-mobile-gui-97-png-files-35315

Sweet Land GUI: 
https://assetstore.unity.com/packages/2d/gui/sweet-land-gui-208285
