/*globals window console document*/
'use strict';

const mazes = [
    [
        "**** **********************",
        "**** *******    ***   *****",
        "**** ******* ** *** *******",
        "      **     ** ***       *",
        "**** *** ********** *******",
        "****                *******",
        "****  * ******* ***    ****",
        "***************************"
    ],
    [
        "***************************",
        "***************       *****",
        "*************** *** *******",
        "      **     ** ***       *",
        "**** *** ********** *******",
        "****                *******",
        "****  * ******* ***    ****",
        "***************************"
    ]],
    ballChar = " ",
    wallChar = "*";

function createGame(pacmanSelector, mazeSelector){
    var pacmanCanvas = document.querySelector(pacmanSelector),
        pacmanCtx = pacmanCanvas.getContext("2d"),
        mazeCanvas = document.querySelector(mazeSelector),
        mazeCtx = mazeCanvas.getContext("2d"),
        isMouthOpen = false,
        steps = 0,
        stepsToChangeMouth = 10,
        pacman = {
            "x": 0,
            "y":92,
            "size": 26,
            "speed": 1
        },
        balls = [],
        walls = [],
        level = 1,
        score = 0,
        isPushedStart = false,
        dir = 0,
        keyCodeToDirs = {
            "37": 2,
            "38" : 3,
            "39" : 0,
            "40": 1
        },
        dirDeltas = [{
            "x": +1,
            "y": 0
        },{
            "x": 0,
            "y": +1
        },{
            "x": -1,
            "y": 0
        },{
            "x": 0,
            "y": -1
        }];

    // 0 -> right
    // 1 -> down
    // 2 -> left
    // 3 -> up

    document.getElementById('level').innerHTML = level;

    var maze = mazes[level - 1];

    const rows = maze.length,
          cols = maze[0].length;

    mazeCanvas.width = (cols + 1) * pacman.size;
    mazeCanvas.height = (rows + 1) * pacman.size;
    pacmanCanvas.width = (cols + 1) * pacman.size;
    pacmanCanvas.height = (rows + 1) * pacman.size;

    function gameLoop(){
        const offset = 5;
        pacmanCtx.clearRect(pacman.x - offset, pacman.y - offset, pacman.size + 2*offset, pacman.size + 2*offset);

        drawPackman();
        steps +=1;

        if(0 === (steps % stepsToChangeMouth)){
            isMouthOpen = !isMouthOpen;
        }

        balls.forEach(function(ball, index) {
            if (areColliding(pacman, ball)) {
                const offset = 5;
                mazeCtx.clearRect(ball.x - offset, ball.y - offset, ball.size + offset * 2, ball.size + offset * 2);
                balls.splice(index, 1);
                score += 10;
                document.getElementById('score').innerHTML = score;
            }
        });

        var isPacmanColidingWithWall= false;
        var nextPosition = {
            "x": pacman.x + dirDeltas[dir].x + 1,
            "y": pacman.y + dirDeltas[dir].y + 1,
            "size": pacman.size - 2
        };

        walls.forEach(function(wall) {
            if (areColliding(wall, nextPosition)) {
                isPacmanColidingWithWall = true;
            }
        });

        if(!isPacmanColidingWithWall){
            if(updatePacmanPosition()){
                pacmanCtx.clearRect(0,0, pacmanCanvas.width, pacmanCanvas.height);
            }
        };

        window.requestAnimationFrame(gameLoop);
    }

    function drawPackman(){
        var deltaRadians,
            x = pacman.x + pacman.size/ 2,
            y = pacman.y + pacman.size/ 2,
            size = pacman.size/ 2;

        pacmanCtx.fillStyle = "yellow";
        pacmanCtx.beginPath();

        if(isMouthOpen){
            deltaRadians = dir *  Math.PI/2;

            pacmanCtx.arc(x, y, size, deltaRadians + Math.PI/4, deltaRadians + 7 * Math.PI/4);
            pacmanCtx.lineTo(x, y);
        } else {
            pacmanCtx.arc(x, y, size, 0, 2 * Math.PI);
        }

        pacmanCtx.fill();
    }

    function drawBall(ball, ctx){
        var x = ball.x + ball.size/ 2,
            y = ball.y + ball.size/ 2,
            size = ball.size/ 2;

        ctx.fillStyle = "orange";
        ctx.beginPath();
        ctx.arc(x, y, size, 0, 2 * Math.PI);
        ctx.fill();
    }

    function positionToBounds(obj){
        var objectCorners = {
                "top": obj.y,
                "left": obj.x,
                "bottom": obj.y + obj.size,
                "right": obj.x + obj.size
        };

        return objectCorners;
    }

    function isBetween(value, min, max){
        return min <= value && value <= max;
    }

    function areColliding(firstObject, secondObject){
        var firstObjectCorners = positionToBounds(firstObject),
            secondObjectCorners = positionToBounds(secondObject);

        return (isBetween(secondObjectCorners.left, firstObjectCorners.left, firstObjectCorners.right) ||
                isBetween(secondObjectCorners.right, firstObjectCorners.left,firstObjectCorners.right)) &&
                (isBetween(secondObjectCorners.top, firstObjectCorners.top, firstObjectCorners.bottom) ||
                isBetween(secondObjectCorners.bottom,firstObjectCorners.top, firstObjectCorners.bottom));
    }

    function updatePacmanPosition(){
        pacman.x += dirDeltas[dir].x * pacman.speed;
        pacman.y += dirDeltas[dir].y * pacman.speed;

        if(pacman.x < 0 || pacman.x >= pacmanCanvas.width ||
            pacman.y < 0 || pacman.y >= pacmanCanvas.height){
            pacman.x = (pacman.x + pacmanCanvas.width) % pacmanCanvas.width;
            pacman.y = (pacman.y + pacmanCanvas.height) % pacmanCanvas.height;

            return true;
        }

        return false;
    };

    document.body.addEventListener("keydown", function(ev){
        ev.preventDefault();

        if(!keyCodeToDirs.hasOwnProperty([ev.keyCode])){
            console.log("Wrong dir!");
            return;
        }

        dir = keyCodeToDirs[ev.keyCode];
        //console.log(ev.keyCode);
        //console.log(dir);
    });

    function drawMazeAndGetBallsAndWalls(ctx, maze, cellSize){
        const ballSize = 15;
        var row,
            col,
            cell,
            obj,
            balls=[],
            walls=[],
            wallInage = document.getElementById("wallImage");

        for(row = 0; row < maze.length; row +=1){
            for(col = 0; col < maze[row].length; col +=1){
                cell = maze[row][col];

                if(cell === ballChar){
                    obj = {
                        "x": col * cellSize + cellSize/4,
                        "y": row * cellSize + cellSize/4,
                        "size": cellSize/2 - 5
                    };

                    balls.push(obj);
                    drawBall(obj, ctx);
                } else if(cell === wallChar){
                    obj = {
                        "x": col * cellSize,
                        "y": row * cellSize,
                        "size": cellSize
                    };

                    ctx.drawImage(wallInage, obj.x, obj.y, cellSize, cellSize);
                    walls.push(obj);
                }
            }
        }

        return [
            balls,
            walls
        ];
    }

    var pacmanImage = document.getElementById("pacmanImage");
    mazeCtx.drawImage(pacmanImage, 300, 10);

    mazeCtx.font = "18px monospace";
    mazeCtx.fillStyle = "rgb(255, 255, 0)";
    mazeCtx.strokeStyle = "rgb(255, 255, 0)";
    mazeCtx.fillText("CLICK 'Start'", 250, 100);
    mazeCtx.strokeText("CLICK 'Start'", 250, 100);
    mazeCtx.fillText("BUTTON TO BEGIN GAME!", 200, 130);
    mazeCtx.strokeText("BUTTON TO BEGIN GAME!", 200, 130);

    document.getElementById('start').addEventListener('click', function() {
        if (isPushedStart === false) {
            isPushedStart = true;
            this.innerText = "Pause";

            mazeCtx.clearRect(0, 0, pacmanCanvas.width, pacmanCanvas.height);
            [balls, walls] = drawMazeAndGetBallsAndWalls(mazeCtx, maze, pacman.size + 4);

            gameLoop();
        } else {
            isPushedStart = false;
            this.innerText = "Start";
        }
    });
}
