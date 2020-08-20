

function jqGet(_option) {
    _option = typeof (_option) == undefined ? {} : _option;
    $.ajax({
        url: _option.url,    //请求的url地址
        dataType: _option.dataType || "json",   //返回格式为json
        async: _option.async || true,//请求是否异步，默认为异步，这也是ajax重要特性
        data: _option.data || null,    //参数值
        type: "get",   //请求方式
        beforeSend: function (res) {
            //请求前的处理
            if (typeof (_option.beforeSend) == "function") {
                _option.beforeSend(res)
            }
        },
        success: function (res) {
            //请求成功时处理
            if (typeof (_option.success) == "function") {
                _option.success(res)
            }
        },
        complete: function (res) {
            //请求完成的处理
            if (typeof (_option.complete) == "function") {
                _option.complete(res)
            }
        },
        error: function (err) {
            //请求出错处理
            if (typeof (_option.error) == "function") {
                _option.error(err)
            }
        }
    });
}

function jqPost( _option) {
    _option = typeof (_option) == undefined ? {} : _option;
    var token = $('input[name="AntiforgeryKey_shiyudong"]').val();
    _option.data.AntiforgeryKey_shiyudong = token;
    $.ajax({
        url: _option.url,    //请求的url地址
        dataType: _option.dataType || "json",   //返回格式为json
        async: _option.async || true,//请求是否异步，默认为异步，这也是ajax重要特性
        data: _option.data || null,    //参数值
        type: "post",   //请求方式
        beforeSend: function (res) {
            //请求前的处理
            if (typeof (_option.beforeSend) == "function") {
                _option.beforeSend(res)
            }
        },
        success: function (res) {
            //请求成功时处理
            if (typeof (_option.success) == "function") {
                _option.success(res)
            }
        },
        complete: function (res) {
            //请求完成的处理
            if (typeof (_option.complete) == "function") {
                _option.complete(res)
            }
        },
        error: function (err) {
            //请求出错处理
            if (typeof (_option.error) == "function") {
                _option.error(err)
            }
        }
    });
}

