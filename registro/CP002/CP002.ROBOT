*** Settings ***
Documentation       Hacer un registro sin llenar los campos requeridos
Library             Selenium2Library

*** Test Cases ***
CP002 Hacer un registro sin llenar los campos requeridos
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Set Screenshot Directory   Pruebas
    Capture Page Screenshot   1.png
    Click Element       xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    sleep   3s
    Capture Page Screenshot   2.png
    Click Element       xpath=/html/body/div/div/div/form/div[7]/input
    Capture Page Screenshot   3.png
    sleep  5s    
    Title Should Be     JSP Page
    Page Should Contain     JSP Page
    Capture Page Screenshot   4.png
    sleep  10s
    Close Browser