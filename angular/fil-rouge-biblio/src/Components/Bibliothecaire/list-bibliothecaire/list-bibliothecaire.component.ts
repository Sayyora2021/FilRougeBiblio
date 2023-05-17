import { Component, OnInit } from '@angular/core';
import { IBibliothecaire } from 'src/Interfaces/IBibliothecaire';
import { BibliothecaireService } from 'src/bibliothecaire.service';

@Component({
  selector: 'app-list-bibliothecaire',
  templateUrl: './list-bibliothecaire.component.html',
  styleUrls: ['./list-bibliothecaire.component.css']
})
export class ListBibliothecaireComponent implements OnInit{
bibliothecaire?: IBibliothecaire[];
  constructor(private bibliothecaireService: BibliothecaireService){
  }

  ngOnInit(): void {
    console.log('init');
    
    this.bibliothecaireService.listAll().subscribe(
      (data: IBibliothecaire[])=>{
        this.bibliothecaire=data;
      })
     
  }

}