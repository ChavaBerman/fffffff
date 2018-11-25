import { Component, OnInit } from '@angular/core';
import { TreeNode } from 'primeng/api';
import {  ReportService, ProjectReport, WorkerForProjectReport } from 'src/app/shared/imports';

@Component({
  selector: 'app-workers-report',
  templateUrl: './workers-report.component.html',
  styleUrls: ['./workers-report.component.css']
})
export class WorkersReportComponent implements OnInit {
  files1: TreeNode[]=[];
  files2: TreeNode[];
  cols: any[];
  projectReportData:Array<ProjectReport>;
  countriesTreeNodes: TreeNode[];
  constructor(private reportService:ReportService) { }

  ngOnInit() {
      this.reportService.createProjectReport().subscribe(data => {
        console.log(data);
        this.projectReportData=data;
        this.projectReportData.forEach(element => {
          this.files1.push(this.dataToTreeNode(element));
        });
        console.log(this.files1);
      
        this.cols = [
          { field: 'projectName', header: 'pName' },
           { field: 'size', header: 'Size' },
           { field: 'type', header: 'Type' }
       ];
});
       
  }
  

  private countryToTreeNode(country: WorkerForProjectReport) : TreeNode {
    return {
        //label: country.userName,
        data: country
    }}
   dataToTreeNode(cont: ProjectReport): TreeNode{
    this.countriesTreeNodes = [];

    
        for (let c of cont.workers) {
            this.countriesTreeNodes.push(this.countryToTreeNode(c));
           
    
    return {
        //label: cont.projectInfo.projectName,
        data: cont.projectInfo,
        children: this.countriesTreeNodes
        }
    };
}

 
}
