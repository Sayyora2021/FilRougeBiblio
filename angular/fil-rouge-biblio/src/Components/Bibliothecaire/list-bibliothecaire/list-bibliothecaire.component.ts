import { Component, OnInit } from '@angular/core';
import { IBibliothecaire } from 'src/Interfaces/IBibliothecaire';
import { BibliothecaireService } from 'src/Services/bibliothecaire.service';

@Component({
  selector: 'app-list-bibliothecaire',
  templateUrl: './list-bibliothecaire.component.html',
  styleUrls: ['./list-bibliothecaire.component.css']
})
export class ListBibliothecaireComponent implements OnInit{
bibliothecaire?: IBibliothecaire[];
nomFiltre: string = '';
nouveauBibliothecaire: IBibliothecaire = { email: '', motDePasse: '', id: 0 }

  constructor(private bibliothecaireService: BibliothecaireService){
  }

  ngOnInit(): void {
    console.log('init');
    
    this.bibliothecaireService.listAll().subscribe(
      (data: IBibliothecaire[])=>{
        this.bibliothecaire=data;
      })
     
  }
  filtrer() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.bibliothecaire)
        this.bibliothecaire = this.bibliothecaire.filter(bibliothecaire =>
          bibliothecaire.email.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.bibliothecaire = this.bibliothecaire;
    }
  }

  delete(bibliothecaire: IBibliothecaire) {
    this.bibliothecaireService.delete(bibliothecaire.id);
    this.bibliothecaire?.splice(this.bibliothecaire.indexOf(bibliothecaire), 1);
  }

  update(bibliothecaire: IBibliothecaire) {
    this.bibliothecaireService.update(bibliothecaire);
  }

  create() {
    this.bibliothecaireService.create(this.nouveauBibliothecaire);
    this.ngOnInit(); this.ngOnInit();
  }
}
