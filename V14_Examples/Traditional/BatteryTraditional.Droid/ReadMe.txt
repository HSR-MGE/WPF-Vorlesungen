Sometimes the Android AVD Emulator is not reacting to changes in the UI.
The values can also be udpated using the shell, e.g.:

adb shell dumpsys battery set level 42
adb shell dumpsys battery set ac 0
adb shell dumpsys battery set status 2          (Charging)
adb shell dumpsys battery set status 3          (Discharging)
adb shell dumpsys battery set status 4          (Not Charging)
adb shell dumpsys battery set status 5          (Full)