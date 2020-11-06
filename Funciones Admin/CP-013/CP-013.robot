*** Settings ***

Documentation      El administrador Edita un usuario (paciente) desde su perfil de administrador
Library          Selenium2Library

*** Test Cases ***


CP 013 El administrador Edita un usuario (paciente) desde su perfil de administrador
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    Capture Page Screenshot   Paso1y2.png
    Input Text          xpath=/html/body/div/div/div/div/form/div[2]/input     Admin
    Input Text          xpath=/html/body/div/div/div/div/form/div[3]/input    1234+1234
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
    Capture Page Screenshot   Paso5.png
    Click Element       xpath=//*[@id="form-list-client-body"]/tr[3]/td[7]/form/input[2]
    Sleep  2s
    Title Should Be      JSP Page
    Capture Page Screenshot   Paso6.png
    Input Text          xpath=/html/body/center/div[2]/form/input[2]     Juan David
    sleep  3s
    Capture Page Screenshot   Paso7.png
    click Element       xpath=/html/body/center/div[2]/form/input[7]
    Capture Page Screenshot   Paso8.png
    Sleep  3s
    Close Browser