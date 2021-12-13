import logo from './logo.svg';
import './App.css';
import TextField from '@mui/material/TextField';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import Button from '@mui/material/Button';
import { useEffect, useState } from 'react';

function App() {
  const [dataRows, setDataRows] = useState();

  function createData(nombre, apellido, correo) {
    return { nombre, apellido, correo };
  }

  const rows = [
    createData('Manuel A.', "Perez", "manuel@gmail.com"),
    createData('Isabel', "Garcia", "manuel@gmail.com"),
  ];

  function addDataToTable(){

  }

  return (
    <div className="App">
      <div>
        <TextField id="fNombre" label="Nombre" variant="filled" />
        <TextField id="fApellido" label="Appelido" variant="filled" />
        <TextField id="fCorreo" label="Correo" variant="filled" />
      </div>
      <div style={{ margin: 10, float: 'right' }}>
        <Button variant="contained">Agregar</Button>
      </div>
      <div>
        <TableContainer component={Paper}>
          <Table sx={{ minWidth: 650 }} aria-label="simple table">
            <TableHead>
              <TableRow>
                <TableCell>Nombre</TableCell>
                <TableCell>Apellido</TableCell>
                <TableCell>Correo</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {rows.map((row) => (
                <TableRow
                  key={rows.correo}
                  sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
                >
                  <TableCell >
                    {row.nombre}
                  </TableCell>
                  <TableCell>{row.apellido}</TableCell>
                  <TableCell>{row.correo}</TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </div>


    </div>
  );
}

export default App;
