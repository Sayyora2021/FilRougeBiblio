import { Component, OnInit } from '@angular/core';
import { IExemplaire } from 'src/Interfaces/IExemplaire';
import { ExemplaireService } from 'src/Services/exemplaire.service';

@Component({
  selector: 'app-list-exemplaires',
  templateUrl: './list-exemplaires.component.html',
  styleUrls: ['./list-exemplaires.component.css']
})
export class ListExemplairesComponent implements OnInit{

  exemplaires? : IExemplaire[];
  nomFiltre: string = '';
  constructor(private exemplaireService: ExemplaireService) {
    
  }
  ngOnInit(): void {
    this.exemplaireService.listAll().subscribe(
      (data: IExemplaire[]) => {
        this.exemplaires = data;
      });
  }
  filtrer() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.exemplaires)
        this.exemplaires = this.exemplaires.filter(exmplaire =>
          exmplaire.livre.titre.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.exemplaires = this.exemplaires;
    }
  }
}
