[<RequireQualifiedAccess>]
module Samples.Recharts.BarCharts.MixBarChart

open Feliz
open Feliz.Recharts
open Fable.Core.Experimental

type Point = { name: string; uv: int; pv: int; amt : int }

let data = [
    { name = "Page A"; uv = 4000; pv = 2400; amt = 2400 }
    { name = "Page B"; uv = 3000; pv = 1398; amt = 2210 }
    { name = "Page C"; uv = 2000; pv = 9800; amt = 2290 }
    { name = "Page D"; uv = 2780; pv = 3908; amt = 2000 }
    { name = "Page E"; uv = 1890; pv = 4800; amt = 2181 }
    { name = "Page F"; uv = 2390; pv = 3800; amt = 2500 }
    { name = "Page G"; uv = 3490; pv = 4300; amt = 2100 }
]


let chart = React.functionComponent <| fun () ->
    Recharts.barChart [
        barChart.width 500
        barChart.height 300
        barChart.data data
        barChart.children [
            Recharts.cartesianGrid [ cartesianGrid.strokeDasharray(3, 3) ]
            Recharts.xAxis [ xAxis.dataKey (fun p -> nameof p.name) ]
            Recharts.yAxis [ ]
            Recharts.tooltip [ ]
            Recharts.bar [
                bar.dataKey (fun point -> nameof point.pv)
                bar.fill "#8884d8"
                bar.stackId "a"
            ]

            Recharts.bar [
                bar.dataKey (fun point -> nameof point.uv)
                bar.fill "#82ca9d"
                bar.stackId "a"
            ]

            Recharts.bar [
                bar.dataKey (fun point -> nameof point.amt)
                bar.fill "#ffc658"
            ]
        ]
    ]