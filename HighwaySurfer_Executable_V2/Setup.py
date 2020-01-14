import cx_Freeze

executables = [cx_Freeze.Executable("HighwaySurfer.py")]

cx_Freeze.setup(
    name = "Highway Surfer",
    options = {"build_exe": {"packages":["pygame"],
                             "include_files":["car2.png",
                                               "gameTitlePage.png",
                                               "lBoardBackground.png",
                                               "controlsBackground.png",
                                               "garageBackground.png",
                                               "greenCar.png",
                                               "blueCar.png",
                                               "greyCar.png",
                                               "orangeCar.png",
                                               "purpleCar.png",
                                               "redCar.png",
                                               "whiteCar.png",
                                               "yellowCar.png",
                                               "backgroundMusic.wav",
                                               "Highscores.py"]}},
    executables = executables
    )
