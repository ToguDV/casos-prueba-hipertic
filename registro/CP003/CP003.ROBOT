*** Settings ***
Documentation       Hacer un registro llenando un solo campo del formulario
Library             Selenium2Library

*** Test Cases ***
CP003 Hacer un registro llenando un solo campo del formulario
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Set Screenshot Directory   Pruebas
    Capture Page Screenshot   1.png
    sleep  5s
    Click Element       xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Capture Page Screenshot   2.png
    sleep  3s
    Input Text      xpath=/html/body/div/div/div/form/div[2]/input    usuario11
    Capture Page Screenshot   3.png
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/form/div[7]/input
    Capture Page Screenshot   4.png
    sleep  5s    
    Title Should Be     JSP Page
    Page Should Contain     Registro
    Capture Page Screenshot   5.png
    sleep  10s
    Close Browser