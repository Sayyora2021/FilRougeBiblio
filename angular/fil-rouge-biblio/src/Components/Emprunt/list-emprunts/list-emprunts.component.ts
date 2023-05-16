import { Component, OnInit } from '@angular/core';
import { IEmprunt } from 'src/Interfaces/IEmprunt';
import { EmpruntService } from 'src/Services/emprunt.service';

@Component({
  selector: 'app-list-emprunts',
  templateUrl: './list-emprunts.component.html',
  styleUrls: ['./list-emprunts.component.css']
})
export class ListEmpruntsComponent implements OnInit {

  emprunts? : IEmprunt[];

  constructor(private empruntService: EmpruntService) {
    
  }
  
  ngOnInit(): void {
    this.empruntService.listAll().subscribe(
      (data: IEmprunt[]) => {
        this.emprunts = data;
      });
  }

  rendre(id:number){
    this.empruntService.delete(id);
  }

}
