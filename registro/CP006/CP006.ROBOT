*** Settings ***
Documentation       Hacer un inicio de sesión sin llenar el campo de Clave
Library             Selenium2Library

*** Test Cases ***
CP006 Hacer un inicio de sesión sin llenar el campo de Clave
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    Input Text      xpath=/html/body/div/div/div/div/form/div[2]/input    Admin
    sleep  1s
    Capture Page Screenshot   1.png
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input  
     sleep  4s
     sleep  1s
    Capture Page Screenshot   2.png
    Title Should Be     Ingresar
    Page Should Contain   Ingresar
    sleep  3s
    Capture Page Screenshot   3.png
    sleep  10s
    Close Browser