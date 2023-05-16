import { Component } from '@angular/core';
import { IExemplaire } from 'src/Interfaces/IExemplaire';
import { ExemplaireService } from 'src/Services/exemplaire.service';

@Component({
  selector: 'app-list-exemplaires',
  templateUrl: './list-exemplaires.component.html',
  styleUrls: ['./list-exemplaires.component.css']
})
export class ListExemplairesComponent {

  exemplaires? : IExemplaire[];

  constructor(private exemplaireService: ExemplaireService) {
    this.exemplaireService.listAll().subscribe(
      (data: IExemplaire[]) => {
        this.exemplaires = data;
      });
  }

}
