jQuery(document).ready(function () {
    $('#btn').click(function () {
        var username = $('input[name=userName]').val();
        var password = $('input[name=passWord]').val();
        if (username == '') {
            $(this).parent().find('.error').fadeOut('fast', function () {
                $(this).css('top', '27px');
            });
            $(this).parent().find('.error').fadeIn('fast', function () {
                $(this).parent().find('.username').focus();
            });
            return false;
        }
        if (password == '') {
            $(this).parent().find('.error').fadeOut('fast', function () {
                $(this).css('top', '96px');
            });
            $(this).parent().find('.error').fadeIn('fast', function () {
                $(this).parent().find('.password').focus();
            });
            return false;
        }
        //$.post('/Manager/Index.html', { username: userName, password: passWord }, function (data) {
        //    if (data != 'false') {
        //        location.href = '/Manager/Index.html'
        //    }
        //});
        location.href = '/Manager/Index.html'
    });
    
    $('input').keyup(function () {
        $(this).parent().find('.error').fadeOut('fast');
    });
});