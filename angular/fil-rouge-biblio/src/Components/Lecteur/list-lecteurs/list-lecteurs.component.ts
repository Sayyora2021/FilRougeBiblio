import { Component, OnInit } from '@angular/core';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-list-lecteurs',
  templateUrl: './list-lecteurs.component.html',
  styleUrls: ['./list-lecteurs.component.css']
})
export class ListLecteursComponent implements OnInit{

  lecteurs? : ILecteur[];
  nomFiltre: string = '';

  constructor(private lecteurService: LecteurService) {
    
  }
  
  ngOnInit(): void {
    this.lecteurService.listAll().subscribe(
      (data: ILecteur[]) => {
        this.lecteurs = data;
      });
  }

  filtrerEmprunts() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.lecteurs)
        this.lecteurs = this.lecteurs.filter(lecteur =>
          lecteur.nom.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.lecteurs = this.lecteurs;
    }
  }

}
