*** Settings ***
Documentation       Hacer un inicio de sesión sin llenar el campo de Usuario
Library             Selenium2Library

*** Test Cases ***
CP005 Hacer un inicio de sesión sin llenar el campo de Usuario
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    sleep  3s
    Capture Page Screenshot   1.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[3]/input    123
    sleep  2s
    Capture Page Screenshot   2.png
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input  
    sleep  5s
    Capture Page Screenshot   3.png
    sleep  3s
    Title Should Be     Ingresar
    Page Should Contain   Ingresar
    Capture Page Screenshot   4.png
    sleep  10s
    Close Browser