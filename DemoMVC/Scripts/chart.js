//SELECT M_Status as label,
//SELECT M_Gender as label,
//GROUP BY M_Gender
//GROUP BY M_Status

$(document).ready(function () {
    ChartGenerate('zune', 'SELECT Status as label,', 'GROUP BY Status', 'User Status Chart', 'Status Counter', 'Status Label', 'status_chart_container', '400', '500');
    ChartGenerate('zune', 'SELECT Gender as label,', 'GROUP BY Gender', 'User Gender Chart', 'Gender Counter', 'Gender Label', 'gender_chart_container', '400', '500');
});

function ChartGenerate(Theme, SelectAsLabel, GroupBy, Caption, X_AxisLbl, Y_AxisLbl, Chart_Id, Chart_Height, Chart_Width) {
    $.ajax({
        url: '/Index/ChartCall',
        type: 'GET',
        cache: false,
        dataType: 'json',
        data: { SelectAsLabel: SelectAsLabel, GroupBy: GroupBy },
        success: function (res) {
            chartData = res.data;
            var chartProperties = {
                "caption": Caption,
                "xAxisName": X_AxisLbl,
                "yAxisName": Y_AxisLbl,
                "rotatevalues": "1",
                "theme": Theme
            };

            apiChart = new FusionCharts({
                type: 'column2d',
                renderAt: Chart_Id,
                width: Chart_Width,
                height: Chart_Height,
                dataFormat: 'json',
                dataSource: {
                    "chart": chartProperties,
                    "data": chartData
                }
            });
            apiChart.render();
        },
        error: function (jqXHR, textStatus, err) {
            alert('text status ' + textStatus + ', err ' + err)
        }
    });

    return true;
}

