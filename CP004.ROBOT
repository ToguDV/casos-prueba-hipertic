*** Settings ***
Documentation       Hacer un inicio de sesión con todos los campos requeridos
Library             Selenium2Library

*** Test Cases ***
CP004 Hacer un inicio de sesión con todos los campos requeridos
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Input Text      xpath=/html/body/div/div/div/div/form/div[2]/input    Admin
    Input Text      xpath=/html/body/div/div/div/div/form/div[3]/input    123
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input  
    sleep  5s    
    Title Should Be     Inicio
    Page Should Contain     Test de hipertensión
    sleep  10s
    Close Browser