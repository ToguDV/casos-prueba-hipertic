*** Settings ***
Documentation       Hacer un registro llenando un solo campo del formulario
Library             Selenium2Library

*** Test Cases ***
CP003 Hacer un registro llenando un solo campo del formulario
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome 
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Click Element       xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Input Text      xpath=/html/body/div/div/div/form/div[2]/input    usuario11
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/form/div[7]/input  
    sleep  5s    
    Title Should Be     JSP Page
    Page Should Contain     Registro
    sleep  10s
    Close Browser