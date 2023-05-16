import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LecteurService {

  constructor(private http: HttpClient) { 
  }




  create(lecteur:ILecteur){
    this.http.post<ILecteur>('https://localhost:7120/api/Lecteurs/Create',lecteur).subscribe();
  }




  update(lecteur:ILecteur,id:number){
    this.http.put<ILecteur>('https://localhost:7120/api/Lecteurs/Edit/'+id,lecteur).subscribe();
  }




  delete(id:number){
    this.http.delete<ILecteur>('https://localhost:7120/api/Lecteurs/Delete/'+id).subscribe();
  }




  detail(id:number) : Observable<ILecteur>{
    return this.http.get<ILecteur>('https://localhost:7120/api/Lecteurs/Detail/' + id);
  }




  listAll() : Observable<ILecteur[]>{

    return this.http.get<ILecteur[]>('https://localhost:7120/api/Lecteurs').pipe(
    map((data: ILecteur[]) => {
      return data;
    })
  );

  }

}
