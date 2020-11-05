*** Settings ***
Documentation       Hacer un registro llenando todos los campos obligatorios
Library             Selenium2Library

*** Test Cases ***
CP001 Hacer un registro llenando todos los campos obligatorios
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Click Element       xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Set Screenshot Directory   C:/Users/cesar/PycharmProjects/prueba2/TestCases/casos-prueba-hipertic/registro
    Capture Page Screenshot   oulxdasdasa.png
    sleep  3s
    Input Text      xpath=/html/body/div/div/div/form/div[2]/input    usuario11
    Input Text      xpath=/html/body/div/div/div/form/div[3]/input    cxzcxz@gmail.com
    Input Text      xpath=/html/body/div/div/div/form/div[4]/input    cxzcxzz
    Input Text      xpath=/html/body/div/div/div/form/div[5]/input    1234+1234
    Input Text      xpath=/html/body/div/div/div/form/div[6]/input    1234+1234
    sleep  5s
    Click Element       xpath=/html/body/div/div/div/form/div[7]/input
    Element Text Should Be    //p[@class='text-danger']    Te registraste con éxito
    sleep  3s
    Title Should Be     JSP Page
    Page Should Contain     Registro
    sleep  3s
    Close Browser