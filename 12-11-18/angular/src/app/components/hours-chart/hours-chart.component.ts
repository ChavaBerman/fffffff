import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hours-chart',
  templateUrl: './hours-chart.component.html',
  styleUrls: ['./hours-chart.component.css']
})
export class HoursChartComponent implements OnInit {

  barChartOptions: any;
  barChartLabels: any;
  barChartType: any;
  barChartLegend: any;
  barChartData: any;
  constructor() { }

  ngOnInit() {
     this.barChartOptions = {
    scaleShowVerticalLines: false,
    responsive: true
  };
   this.barChartLabels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
   this.barChartType = 'bar';
   this.barChartLegend = true;
 
   this.barChartData = [
    {data: [65, 59, 80, 81, 56, 55, 40], label: 'name project'},
    {data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B'}
  ];


  }
  public chartClicked(e:any):void {
    console.log(e);
  }
 
  public chartHovered(e:any):void {
    console.log(e);
  }

}
