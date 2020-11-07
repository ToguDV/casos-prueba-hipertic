*** Settings ***
Documentation       Hacer un inicio de sesión ingresando incorrectamente el usuario
Library             Selenium2Library

*** Test Cases ***
CP007 Hacer un inicio de sesión ingresando incorrectamente el usuario
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    sleep  2s
    Capture Page Screenshot   1.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[2]/input    admin1
    sleep  1s
    Capture Page Screenshot   2.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[3]/input    123
    sleep  1s
    Capture Page Screenshot   3.png
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input
    sleep  1s
    Capture Page Screenshot   4.png
    sleep  4s
    Title Should Be     Ingresar
    Page Should Contain   Ingresar
    sleep  1s
    Capture Page Screenshot   5.png
    sleep  10s
    Close Browser