﻿/*jshint -W032*/
/*global getAjax, getAjaxErrorMessage, logError, saveButton, url:true, validateProductControl, errorLabelBottom, appendParameter, getData, valueDate, storeId, partyCode, priceTypeId, referenceNumber, data, statementReference, agentId, shipperId, shippingAddressCode, shippingCharge, costCenterId, transactionIds, attachments*/

if (typeof (saveButton) === "undefined") {
    saveButton = $("#SaveButton");
};


saveButton.click(function () {
    if (validateProductControl()) {
        save();
    };
});

var save = function () {
    saveButton.addClass("loading");
    var ajaxSaveOder = saveOrder(valueDate, storeId, partyCode, priceTypeId, referenceNumber, data, shippingAddressCode, shipperId, shippingCharge, costCenterId, statementReference, transactionIds, attachments, nonTaxable, salespersonId);

    ajaxSaveOder.done(function (response) {
        var id = response.d;
        window.location = "/Modules/Sales/Confirmation/Order.mix?TranId=" + id;
    });

    ajaxSaveOder.fail(function (jqXHR) {
        saveButton.removeClass("loading");
        var errorMessage = getAjaxErrorMessage(jqXHR);
        errorLabelBottom.html(errorMessage);
        logError(errorMessage);
    });
};

var saveOrder = function (valueDate, storeId, partyCode, priceTypeId, referenceNumber, data, shippingAddressCode, shipperId, shippingCharge, costCenterId, statementReference, transactionIds, attachments, nonTaxable, salespersonId) {
    var d = "";
    d = appendParameter(d, "valueDate", valueDate);
    d = appendParameter(d, "storeId", storeId);
    d = appendParameter(d, "partyCode", partyCode);
    d = appendParameter(d, "priceTypeId", priceTypeId);
    d = appendParameter(d, "referenceNumber", referenceNumber);
    d = appendParameter(d, "data", data);
    d = appendParameter(d, "statementReference", statementReference);
    d = appendParameter(d, "transactionIds", transactionIds);
    d = appendParameter(d, "attachmentsJSON", attachments);
    d = appendParameter(d, "nonTaxable", nonTaxable);
    d = appendParameter(d, "salespersonId", salespersonId);
    d = appendParameter(d, "shipperId", shipperId);
    d = appendParameter(d, "shippingAddressCode", shippingAddressCode);

    d = getData(d);
    url = "/Modules/Sales/Services/Entry/Order.asmx/Save";

    return getAjax(url, d);
};