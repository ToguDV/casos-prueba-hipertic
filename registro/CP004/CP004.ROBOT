*** Settings ***
Documentation       Hacer un inicio de sesión con todos los campos requeridos
Library             Selenium2Library

*** Test Cases ***
CP004 Hacer un inicio de sesión con todos los campos requeridos
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    sleep  3s
    Capture Page Screenshot   1.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[2]/input    Admin
    sleep  3s
    Capture Page Screenshot   2.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[3]/input    123
    sleep  3s
    Capture Page Screenshot   3.png
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input
    sleep  3s
    Capture Page Screenshot   4.png
    Title Should Be     Inicio
    Page Should Contain     Test de hipertensión
    Capture Page Screenshot   5.png
    sleep  10s
    Close Browser