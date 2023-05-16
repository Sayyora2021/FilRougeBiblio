import { Component, OnInit } from '@angular/core';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { AuteurService } from 'src/Services/auteur.service';

@Component({
  selector: 'app-list-auteurs',
  templateUrl: './list-auteurs.component.html',
  styleUrls: ['./list-auteurs.component.css']
})
export class ListAuteursComponent implements OnInit{

  auteurs? : IAuteur[];

  constructor(private auteurService: AuteurService) {
    
  }
  ngOnInit(): void {
    this.auteurService.listAll().subscribe(
      (data: IAuteur[]) => {
        this.auteurs = data;
      });
  }

}
