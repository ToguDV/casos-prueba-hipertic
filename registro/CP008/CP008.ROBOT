*** Settings ***
Documentation       Hacer un inicio de sesión ingresando incorrectamente la contraseña
Library             Selenium2Library

*** Test Cases ***
CP008 Hacer un inicio de sesión ingresando incorrectamente la contraseña
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    sleep  1s
    Capture Page Screenshot   1.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[2]/input    admin
    sleep  1s
    Capture Page Screenshot   2.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[3]/input    1234
    sleep  2s
    sleep  1s
    Capture Page Screenshot   3.png
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input
    sleep  1s
    Capture Page Screenshot   4.png
    sleep  5s    
    Title Should Be     Ingresar
    Page Should Contain   Ingresar
    sleep  1s
    Capture Page Screenshot   5.png
    sleep  10s
    Close Browser