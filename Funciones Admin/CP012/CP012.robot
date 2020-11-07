*** Settings ***

Documentation      El administrador registra un usuario (paciente) desde su perfil de administrador
Library          Selenium2Library

*** Test Cases ***


CP 012 El administrador registra un usuario (paciente) desde su perfil de administrador
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    Capture Page Screenshot   Paso1y2.png
    Input Text          xpath=/html/body/div/div/div/div/form/div[2]/input     Admin
    Input Text          xpath=/html/body/div/div/div/div/form/div[3]/input    123
    Capture Page Screenshot   Paso3.png
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input
    sleep  5s
    Title Should Be     Inicio
    Capture Page Screenshot   Paso3-2.png
    Click Element       xpath=/html/body/nav/ul/li[4]/a
    Sleep  3s
    Capture Page Screenshot   Paso4.png
    Click Element       xpath=//*[@id="form-list-client"]/input[1]
    Sleep  3s
    Click Element       xpath=//*[@id="form-list-client"]/input[2]
    Title Should Be     JSP Page
    Capture Page Screenshot   Paso5.png
    Input Text          xpath=/html/body/center/div[2]/form/input[1]    1001004423
    Sleep  3s
    Input Text          xpath=/html/body/center/div[2]/form/input[2]    Mateo Rodriguez
    Sleep  3s
    Input Text          xpath=/html/body/center/div[2]/form/input[3]    Mateo@email.com
    Sleep  3s
    Input Text          xpath=/html/body/center/div[2]/form/input[4]    1234+1234
    Sleep  3s
    Input Text          xpath=/html/body/center/div[2]/form/input[5]    Mateo Rodriguez
    Sleep  3s
    Input Text          xpath=/html/body/center/div[2]/form/input[6]    50
    Sleep  3s
    Capture Page Screenshot   Paso6.png
    Click Element       xpath=/html/body/center/div[2]/form/input[7]
    Title Should Be     JSP Page
    Capture Page Screenshot   Paso7.png
    Sleep  5s
    Close Browser